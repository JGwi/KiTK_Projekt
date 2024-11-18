using System;
using System.IO;
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

                if (File.Exists(szukajOknoText.Text))
                {
                    File.Delete(szukajOknoText.Text);
                    szukajOknoText.Text = string.Empty;
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
    }
}