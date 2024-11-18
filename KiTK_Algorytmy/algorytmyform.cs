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
            fs.Write(salt, 0, salt.Length);

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

                /*if (File.Exists(szukajOknoText.Text))
                {
                    File.Delete(szukajOknoText.Text);
                    szukajOknoText.Text = string.Empty;
                }*/
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
                byte[] salt = new byte[32];
                fsIn.Read(salt, 0, salt.Length);

                int extensionLength = fsIn.ReadByte(); 
                byte[] extensionBytes = new byte[extensionLength];
                fsIn.Read(extensionBytes, 0, extensionLength);
                string originalExtension = Encoding.UTF8.GetString(extensionBytes);

                string decryptedFile = Path.ChangeExtension(encryptedFile, originalExtension);

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