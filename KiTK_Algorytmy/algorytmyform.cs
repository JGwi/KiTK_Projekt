using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KiTK_Algorytmy
{
    public partial class algorytmyform : Form
    {
        private string _password = "Pasword2123";

        public algorytmyform()
        {
            InitializeComponent();
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.DefaultExt = ".txt";

            DialogResult result = op.ShowDialog();
            if (result == DialogResult.OK)
            {
                szukajOknoText.Text = op.FileName;
                using (StreamReader sr = new StreamReader(op.FileName))
                {
                    tekstPlikText.Text = sr.ReadToEnd();
                }
            }
        }

        private void btnSzyfrAES_Click(object sender, EventArgs e)
        {

            byte[] salt = GenerateSalt();
            var localLink = Path.ChangeExtension(szukajOknoText.Text, ".aes");
            FileStream fs = new FileStream(localLink, FileMode.Create);
            byte[] passwordBytes = Encoding.Unicode.GetBytes(_password);

            RijndaelManaged aes = new RijndaelManaged
            {
                KeySize = 256,
                BlockSize = 128,
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CFB
            };

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);

            // 1. Zapisanie identyfikatora algorytmu
            string algorithmIdentifier = "AES"; // Identyfikator algorytmu
            byte[] algorithmBytes = Encoding.UTF8.GetBytes(algorithmIdentifier.PadRight(8, '\0')); // 8 bajtów nagłówka
            fs.Write(algorithmBytes, 0, algorithmBytes.Length); // Zapis identyfikatora

            // 2. Zapisanie soli
            fs.Write(salt, 0, salt.Length);

            // 3. Zapisanie rozszerzenia pliku
            string fileExtension = Path.GetExtension(szukajOknoText.Text);
            byte[] extensionBytes = Encoding.UTF8.GetBytes(fileExtension);
            fs.WriteByte((byte)extensionBytes.Length); // Zapis długości rozszerzenia
            fs.Write(extensionBytes, 0, extensionBytes.Length);

            CryptoStream cs = new CryptoStream(fs, aes.CreateEncryptor(), CryptoStreamMode.Write);
            FileStream fsIn = new FileStream(szukajOknoText.Text, FileMode.Open);

            byte[] buffer = new byte[108576];
            int read;
            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    cs.Write(buffer, 0, read); // Dane są szyfrowane przez CryptoStream
                }
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Błąd szyfrowania: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nieoczekiwany błąd: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fs.Close();
                fsIn.Close();

                MessageBox.Show("Plik został zaszyfrowany jako: " + localLink);

                using (StreamReader sr = new StreamReader(localLink))
                {
                    zaszyfrowanyText.Text = sr.ReadToEnd();
                }
            }
        }

        private byte[] GenerateSalt()
        {
            byte[] data = new byte[32];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(data); // Generuje losowy salt
            }
            return data;
        }

        private void btnDeszyfrAES_Click(object sender, EventArgs e)
{
    string encryptedFile = szukajOknoText.Text;
    if (!File.Exists(encryptedFile))
    {
        MessageBox.Show("Nie znaleziono pliku do odszyfrowania.");
        return;
    }

    using (FileStream fsIn = new FileStream(encryptedFile, FileMode.Open))
    {
        // 1. Odczytanie i weryfikacja identyfikatora algorytmu
        byte[] algorithmBytes = new byte[8]; // 8 bajtów identyfikatora
        fsIn.Read(algorithmBytes, 0, algorithmBytes.Length);
        string algorithmIdentifier = Encoding.UTF8.GetString(algorithmBytes).Trim('\0');

        // Sprawdzenie, czy użyto algorytmu AES
        if (algorithmIdentifier != "AES")
        {
            MessageBox.Show($"Nieprawidłowy algorytm szyfrowania: {algorithmIdentifier}. Oczekiwano: AES.");
            return; // Zakończ deszyfrowanie, jeśli algorytm się nie zgadza
        }

        // 2. Odczytanie soli
        byte[] salt = new byte[32];
        fsIn.Read(salt, 0, salt.Length);

        // 3. Odczytanie rozszerzenia pliku
        int extensionLength = fsIn.ReadByte(); 
        byte[] extensionBytes = new byte[extensionLength];
        fsIn.Read(extensionBytes, 0, extensionLength);
        string originalExtension = Encoding.UTF8.GetString(extensionBytes);

        // 4. Przygotowanie nazwy pliku odszyfrowanego
        string decryptedFile = Path.ChangeExtension(encryptedFile, originalExtension);

        // 5. Przygotowanie klucza AES
        byte[] passwordBytes = Encoding.Unicode.GetBytes(_password);
        RijndaelManaged aes = new RijndaelManaged
        {
            KeySize = 256,
            BlockSize = 128,
            Padding = PaddingMode.PKCS7,
            Mode = CipherMode.CFB
        };

        var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
        aes.Key = key.GetBytes(aes.KeySize / 8);
        aes.IV = key.GetBytes(aes.BlockSize / 8);

        // 6. Proces deszyfrowania
        using (CryptoStream cs = new CryptoStream(fsIn, aes.CreateDecryptor(), CryptoStreamMode.Read))
        using (FileStream fsOut = new FileStream(decryptedFile, FileMode.Create))
        {
            byte[] buffer = new byte[108576];
            int read;
            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsOut.Write(buffer, 0, read);
                }

                MessageBox.Show("Plik został odszyfrowany jako: " + decryptedFile);
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Błąd deszyfrowania: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nieoczekiwany błąd: " + ex.Message);
            }
        }
    }
}


        private void btnSzyfrDES_Click(object sender, EventArgs e)
        {
            byte[] salt = GenerateSalt();
            var localLink = szukajOknoText.Text + ".des";
            FileStream fs = new FileStream(localLink, FileMode.Create);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(_password);

            DESCryptoServiceProvider des = new DESCryptoServiceProvider
            {
                KeySize = 64,
                BlockSize = 64,
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CFB
            };

            // Skrócenie hasła do 8 bajtów (efektywny klucz DES)
            byte[] key = passwordBytes.Take(8).ToArray();
            des.Key = key;
            des.IV = key;

            // Dodanie identyfikatora algorytmu
            byte[] algorithmBytes = Encoding.UTF8.GetBytes("DES".PadRight(8, '\0')); // 8-bajtowy identyfikator
            fs.Write(algorithmBytes, 0, algorithmBytes.Length);

            // Zapis soli
            fs.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fs, des.CreateEncryptor(), CryptoStreamMode.Write);
            FileStream fsIn = new FileStream(szukajOknoText.Text, FileMode.Open);

            byte[] buffer = new byte[4096];
            int read;
            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    cs.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Błąd szyfrowania DES: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fs.Close();
                fsIn.Close();

                MessageBox.Show("Plik został zaszyfrowany jako: " + localLink);
            }
        }


        private void btnDeszyfrDES_Click(object sender, EventArgs e)
        {
            string encryptedFile = szukajOknoText.Text;
            if (!File.Exists(encryptedFile))
            {
                MessageBox.Show("Nie znaleziono pliku do odszyfrowania.");
                return;
            }

            using (FileStream fsIn = new FileStream(encryptedFile, FileMode.Open))
            {
                // Odczyt identyfikatora algorytmu
                byte[] algorithmBytes = new byte[8]; // 8 bajtów identyfikatora
                fsIn.Read(algorithmBytes, 0, algorithmBytes.Length);
                string algorithmIdentifier = Encoding.UTF8.GetString(algorithmBytes).Trim('\0');

                // Weryfikacja identyfikatora
                if (algorithmIdentifier != "DES")
                {
                    MessageBox.Show($"Nieprawidłowy algorytm szyfrowania: {algorithmIdentifier}. Oczekiwano: DES.");
                    return; // Zakończ deszyfrowanie, jeśli algorytm się nie zgadza
                }

                // Odczyt soli
                byte[] salt = new byte[32];
                fsIn.Read(salt, 0, salt.Length);

                byte[] passwordBytes = Encoding.UTF8.GetBytes(_password);

                DESCryptoServiceProvider des = new DESCryptoServiceProvider
                {
                    KeySize = 64,
                    BlockSize = 64,
                    Padding = PaddingMode.PKCS7,
                    Mode = CipherMode.CFB
                };

                byte[] key = passwordBytes.Take(8).ToArray();
                des.Key = key;
                des.IV = key;

                string decryptedFile = encryptedFile.Replace(".des", "");

                using (CryptoStream cs = new CryptoStream(fsIn, des.CreateDecryptor(), CryptoStreamMode.Read))
                using (FileStream fsOut = new FileStream(decryptedFile, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    int read;
                    try
                    {
                        while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fsOut.Write(buffer, 0, read);
                        }

                        MessageBox.Show("Plik został odszyfrowany jako: " + decryptedFile);
                    }
                    catch (CryptographicException ex)
                    {
                        MessageBox.Show("Błąd deszyfrowania DES: " + ex.Message);
                    }
                }
            }
        }


    }
}