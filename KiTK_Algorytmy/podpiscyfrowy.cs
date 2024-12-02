using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KiTK_Algorytmy
{
    public partial class podpiscyfrowy : Form
    {
        private readonly string _secretKey = "KluczSymetryczny123"; // Przykładowy klucz symetryczny (do zmiany na bezpieczniejszy)

        public podpiscyfrowy()
        {
            InitializeComponent();
        }

        // Obsługa przycisku "Generuj podpis"
        private void btnGenerateSignature_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text; // Ścieżka do pliku PDF
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Nie wybrano pliku lub plik nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 1. Generowanie funkcji skrótu
                byte[] fileHash = GenerateFileHash(filePath);
                cmbHashAlgorithm.Text = BitConverter.ToString(fileHash).Replace("-", ""); // Wyświetlenie funkcji skrótu w TextBox

                // 2. Szyfrowanie funkcji skrótu (generowanie podpisu cyfrowego)
                byte[] signature = EncryptHash(fileHash, _secretKey);

                // 3. Zapis podpisu cyfrowego do pliku
                string signatureFile = Path.ChangeExtension(filePath, ".signature");
                File.WriteAllBytes(signatureFile, signature);

                MessageBox.Show($"Podpis cyfrowy wygenerowany i zapisany jako: {signatureFile}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcjonalnie: wyświetlenie podpisu cyfrowego w TextBox
                rtbSignatureOutput.Text = BitConverter.ToString(signature).Replace("-", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas generowania podpisu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funkcja generująca funkcję skrótu (SHA-256)
        private byte[] GenerateFileHash(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(fs); // Wyliczenie skrótu
            }
        }



        // Funkcja szyfrująca funkcję skrótu kluczem symetrycznym (AES)
        private byte[] EncryptHash(byte[] hash, string secretKey)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(secretKey.PadRight(32).Substring(0, 32)); // Klucz 256-bitowy
                aes.IV = new byte[16]; // Domyślne IV (zainicjalizowane zerami)

                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(hash, 0, hash.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray(); // Zwrócenie zaszyfrowanych danych
                }
            }
        }
    }
}
