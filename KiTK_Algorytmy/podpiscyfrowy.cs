using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace KiTK_Algorytmy
{
    public partial class podpiscyfrowy : Form
    {
        private readonly string _secretKey = "KluczSymetryczny123"; 

        public podpiscyfrowy()
        {
            InitializeComponent();
        }

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
                byte[] fileHash = GenerateFileHash(filePath);
                cmbHashAlgorithm.Text = BitConverter.ToString(fileHash).Replace("-", ""); // Wyświetlenie funkcji skrótu w TextBox

                byte[] signature = EncryptHash(fileHash, _secretKey);

                string signatureFile = Path.ChangeExtension(filePath, ".signature");
                File.WriteAllBytes(signatureFile, signature);

                MessageBox.Show($"Podpis cyfrowy wygenerowany i zapisany jako: {signatureFile}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                rtbSignatureOutput.Text = BitConverter.ToString(signature).Replace("-", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas generowania podpisu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] GenerateFileHash(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(fs); // Wyliczenie skrótu
            }
        }



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

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.DefaultExt = ".txt";

            DialogResult result = op.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePath.Text = op.FileName;
            }
        }

        private void btnSelectCertificate_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.DefaultExt = ".txt";

            DialogResult result = op.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCertificatePath.Text = op.FileName;
            }
        }

        private void btnAnalyzeCertificate_Click(object sender, EventArgs e)
        {
            // Pobranie ścieżki certyfikatu z TextBox
            string certificatePath = txtCertificatePath.Text;

            // Sprawdzenie poprawności ścieżki
            if (string.IsNullOrEmpty(certificatePath) || !System.IO.File.Exists(certificatePath))
            {
                MessageBox.Show("Proszę wybrać poprawny plik certyfikatu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Odczyt certyfikatu z pliku
                X509Certificate2 certificate = new X509Certificate2(certificatePath);

                // Analiza szczegółów certyfikatu
                StringBuilder certDetails = new StringBuilder();
                certDetails.AppendLine("=== Szczegóły Certyfikatu ===");
                certDetails.AppendLine($"Wystawca: {certificate.Issuer}");
                certDetails.AppendLine($"Właściciel: {certificate.Subject}");
                certDetails.AppendLine($"Data ważności od: {certificate.NotBefore}");
                certDetails.AppendLine($"Data ważności do: {certificate.NotAfter}");
                certDetails.AppendLine($"Algorytm podpisu: {certificate.SignatureAlgorithm.FriendlyName}");
                certDetails.AppendLine($"Numer seryjny: {certificate.SerialNumber}");
                certDetails.AppendLine($"Klucz publiczny: {certificate.PublicKey.Key.KeySize} bity");
                certDetails.AppendLine($"Fingerprint SHA256: {BitConverter.ToString(certificate.GetCertHash()).Replace("-", ":")}");

                // Wyświetlenie informacji o rozszerzeniach certyfikatu
                if (certificate.Extensions.Count > 0)
                {
                    certDetails.AppendLine("\n--- Rozszerzenia Certyfikatu ---");
                    foreach (var extension in certificate.Extensions)
                    {
                        certDetails.AppendLine($"{extension.Oid.FriendlyName} ({extension.Oid.Value})");
                    }
                }

                // Wyświetlanie danych w RichTextBox
                rtbCertificateDetails.Text = certDetails.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas analizy certyfikatu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
