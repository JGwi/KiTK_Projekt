using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiTK_Algorytmy
{
    public partial class szyfrowanieform : Form
    {
        private const string alfabetJawny = "abcdefghijklmnopqrstuvwxyz";
        private const string alfabetKryptogramu = "cegikmoqsuwyabdfhjlnprtvxz";
        public szyfrowanieform()
        {
            InitializeComponent();
        }

        private string ProstySzyfrPodstawieniowy(string tekstJawny)
        {
            char[] zaszyfrowanyTekst = new char[tekstJawny.Length];

            for (int i = 0; i < tekstJawny.Length; i++)
            {
                char znak = tekstJawny[i];

                if (char.IsLetter(znak))
                {
                    char lowerChar = char.ToLower(znak);
                    int index = alfabetJawny.IndexOf(lowerChar);

                    if (index != -1)
                    {
                        char zaszyfrowanyZnak = alfabetKryptogramu[index];
                        zaszyfrowanyTekst[i] = char.IsUpper(znak) ? char.ToUpper(zaszyfrowanyZnak) : zaszyfrowanyZnak;
                    }
                    else
                    {
                        zaszyfrowanyTekst[i] = znak; // Znak pozostaje bez zmian
                    }
                }
                else
                {
                    zaszyfrowanyTekst[i] = znak; // Obsługa znaków nieliterowych
                }
            }
            return new string(zaszyfrowanyTekst);
        }


        private string DeszyfrujProstySzyfrPodstawieniowy(string tekst)
        {
            StringBuilder wynik = new StringBuilder();

            foreach (char znak in tekst)
            {
                if (char.IsLetter(znak))
                {
                    // Znajdujemy indeks litery w alfabecie kryptogramu
                    int indeks = alfabetKryptogramu.IndexOf(char.ToLower(znak));

                    if (indeks != -1)
                    {
                        // Pobieramy literę z alfabetu jawnego na podstawie indeksu
                        char odszyfrowanaLitera = alfabetJawny[indeks];
                        // Zwracamy z powrotem wielką literę, jeśli oryginalny znak był wielką literą
                        wynik.Append(char.IsUpper(znak) ? char.ToUpper(odszyfrowanaLitera) : odszyfrowanaLitera);
                    }
                    else
                    {
                        wynik.Append(znak); // Jeśli znak nie jest literą, dodajemy go bez zmian
                    }
                }
                else
                {
                    wynik.Append(znak); // Zachowujemy inne znaki (spacje, cyfry, znaki specjalne)
                }
            }

            return wynik.ToString();
        }

        private string SzyfrTranspozycyjny(string tekst, string klucz)
        {
            // Usuń spacje z klucza (opcjonalnie, w zależności od reguł szyfrowania)
            char[] kluczZnaki = klucz.ToCharArray();
            char[] posortowanyKlucz = (char[])kluczZnaki.Clone();
            Array.Sort(posortowanyKlucz); // Sortowanie klucza

            // Oblicz liczbę kolumn na podstawie długości klucza
            int kolumny = klucz.Length;
            int wiersze = (int)Math.Ceiling((double)tekst.Length / kolumny);

            // Uzupełnij tekst spacjami, jeśli długość tekstu nie jest podzielna przez liczbę kolumn
            while (tekst.Length % kolumny != 0)
            {
                tekst += ' ';
            }

            // Utwórz tablicę znaków (wiersze * kolumny)
            char[,] tablica = new char[wiersze, kolumny];
            int indeks = 0;

            // Wypełnij tablicę znakami tekstu wierszami
            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {
                    if (indeks < tekst.Length)
                    {
                        tablica[i, j] = tekst[indeks++];
                    }
                }
            }

            // Utwórz zaszyfrowany tekst, odczytując kolumnami według posortowanego klucza
            StringBuilder zaszyfrowanyTekst = new StringBuilder();

            for (int k = 0; k < kolumny; k++)
            {
                // Znajdź indeks aktualnego znaku w oryginalnym kluczu
                int indeksKlucza = Array.IndexOf(kluczZnaki, posortowanyKlucz[k]);

                // Odczytujemy kolumnę o indeksie indeksKlucza
                for (int i = 0; i < wiersze; i++)
                {
                    zaszyfrowanyTekst.Append(tablica[i, indeksKlucza]);
                }
            }

            return zaszyfrowanyTekst.ToString();
        }

        private string DeszyfrujSzyfrTranspozycyjny(string tekstZaszyfrowany, string klucz)
        {
            char[] kluczZnaki = klucz.ToCharArray();
            char[] posortowanyKlucz = (char[])kluczZnaki.Clone();
            Array.Sort(posortowanyKlucz); // Sortujemy klucz

            int kolumny = klucz.Length;
            int wiersze = (int)Math.Ceiling((double)tekstZaszyfrowany.Length / kolumny);

            // Utwórz macierz, w której będziemy przechowywać zaszyfrowane znaki
            char[,] tablica = new char[wiersze, kolumny];
            int indeks = 0;

            // Wypełnij tablicę kolumnami zgodnie z posortowanym kluczem
            for (int k = 0; k < kolumny; k++)
            {
                int indeksKlucza = Array.IndexOf(kluczZnaki, posortowanyKlucz[k]);

                for (int i = 0; i < wiersze; i++)
                {
                    if (indeks < tekstZaszyfrowany.Length)
                    {
                        tablica[i, indeksKlucza] = tekstZaszyfrowany[indeks++];
                    }
                }
            }

            // Odczytujemy tablicę wierszami, aby uzyskać tekst oryginalny
            StringBuilder odszyfrowanyTekst = new StringBuilder();

            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {
                    odszyfrowanyTekst.Append(tablica[i, j]);
                }
            }

            return odszyfrowanyTekst.ToString().TrimEnd(); // Usuwamy nadmiarowe spacje
        }

        private void AdjustTextBoxHeight(TextBox textBox)
        {
            // Zablokowanie zmian wizualnych na czas obliczeń
            textBox.SuspendLayout();

            // Ustaw maksymalną wysokość w zależności od tekstu i ograniczeń okna
            int numLines = textBox.GetLineFromCharIndex(textBox.Text.Length) + 1;
            int textBoxHeight = numLines * textBox.Font.Height + 10; // Oblicz wysokość TextBoxa w zależności od liczby wierszy

            // Ustawienie minimalnej i maksymalnej wysokości
            textBox.Height = Math.Min(textBoxHeight, this.ClientSize.Height / 2);  // Maksymalnie połowa wysokości formularza

            // Odblokowanie zmian wizualnych
            textBox.ResumeLayout();
        }

        private void TesktZaszyfrowany_TextChanged(object sender, EventArgs e)
        {
            AdjustTextBoxHeight(TekstDoSzyfrowania);
        }

        private void TekstDoSzyfrowania_TextChanged(object sender, EventArgs e)
        {
            AdjustTextBoxHeight(TesktZaszyfrowany);

        }



        private void checkBoxProstySzyfr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProstySzyfr.Checked)
            {
                checkBoxSzyfrTranspozycyjnym.Checked = false;
                checkBoxPodstawienieHaslem.Checked = false;
                checkBoxPrzesuniecieCykliczne.Checked = false;
            }
        }

        private void checkBoxSzyfrTranspozycyjnym_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSzyfrTranspozycyjnym.Checked)
            {
                checkBoxProstySzyfr.Checked = false;
                checkBoxPodstawienieHaslem.Checked = false;
                checkBoxPrzesuniecieCykliczne.Checked = false;
            }
        }

        private void checkBoxPodstawienieHaslem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPodstawienieHaslem.Checked)
            {
                checkBoxProstySzyfr.Checked = false;
                checkBoxSzyfrTranspozycyjnym.Checked = false;
                checkBoxPrzesuniecieCykliczne.Checked = false;

            }
        }

        private void checkBoxPrzesuniecieCykliczne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrzesuniecieCykliczne.Checked)
            {
                checkBoxProstySzyfr.Checked = false;
                checkBoxSzyfrTranspozycyjnym.Checked = false;
                checkBoxPodstawienieHaslem.Checked = false;
            }
        }

        private void btnImportujPlik_Click(object sender, EventArgs e)
        {
            // Stworzenie okna dialogowego OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";  // Filtr dla plików tekstowych
            openFileDialog.Title = "Wybierz plik tekstowy do importu";

            // Sprawdzenie, czy użytkownik wybrał plik i kliknął "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Odczytanie zawartości pliku
                string filePath = openFileDialog.FileName;
                try
                {
                    // Wczytanie zawartości pliku do TextBoxa "TekstDoSzyfrowania"
                    string fileContent = File.ReadAllText(filePath);
                    TekstDoSzyfrowania.Text = fileContent;  // Wstawienie tekstu do TextBoxa
                }
                catch (Exception ex)
                {
                    // Obsługa błędów podczas odczytu pliku
                    MessageBox.Show("Wystąpił błąd podczas wczytywania pliku: " + ex.Message);
                }
            }
        }

        private void btnEksportujPlik_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";  // Filtr dla plików tekstowych
            saveFileDialog.Title = "Zapisz zaszyfrowany tekst";

            // Sprawdzenie, czy użytkownik wybrał lokalizację i kliknął "Zapisz"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Zapisanie zawartości "TesktZaszyfrowany" do wybranego pliku
                    File.WriteAllText(filePath, TesktZaszyfrowany.Text);
                    MessageBox.Show("Plik został zapisany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Obsługa błędów zapisu pliku
                    MessageBox.Show("Wystąpił błąd podczas zapisywania pliku: " + ex.Message);
                }
            }
        }

        private string SzyfrPodstawieniowyZHaslem(string input, string klucz)
        {
            // Normalizacja klucza i tekstu wejściowego do wielkich liter
            klucz = klucz.ToUpper();
            input = input.ToUpper();

            // Usunięcie duplikatów w haśle i stworzenie alfabetu kryptograficznego
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alfabetKryptogramu = new string(klucz.Distinct().ToArray());  // Unikalne litery hasła

            // Dodanie pozostałych liter alfabetu, które nie występują w haśle
            foreach (char c in alfabet)
            {
                if (!alfabetKryptogramu.Contains(c))
                {
                    alfabetKryptogramu += c;
                }
            }

            // Szyfrowanie tekstu jawnego
            char[] zaszyfrowanyTekst = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int indexInAlfabet = alfabet.IndexOf(currentChar);

                // Jeśli znak jest literą z alfabetu, zaszyfruj go
                if (indexInAlfabet >= 0)
                {
                    zaszyfrowanyTekst[i] = alfabetKryptogramu[indexInAlfabet];
                }
                else
                {
                    zaszyfrowanyTekst[i] = currentChar;  // Zostaw znak bez zmian, jeśli nie jest literą
                }
            }

            return new string(zaszyfrowanyTekst);
        }

        private string DeszyfrujPodstawieniowyZHaslem(string input, string klucz)
        {
            // Normalizacja klucza i tekstu wejściowego do wielkich liter
            klucz = klucz.ToUpper();
            input = input.ToUpper();

            // Usunięcie duplikatów w haśle i stworzenie alfabetu kryptograficznego
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alfabetKryptogramu = new string(klucz.Distinct().ToArray());  // Unikalne litery hasła

            // Dodanie pozostałych liter alfabetu, które nie występują w haśle
            foreach (char c in alfabet)
            {
                if (!alfabetKryptogramu.Contains(c))
                {
                    alfabetKryptogramu += c;
                }
            }

            // Deszyfrowanie tekstu
            char[] odszyfrowanyTekst = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int indexInKryptogram = alfabetKryptogramu.IndexOf(currentChar);

                if (indexInKryptogram >= 0)
                {
                    odszyfrowanyTekst[i] = alfabet[indexInKryptogram];
                }
                else
                {
                    odszyfrowanyTekst[i] = currentChar;
                }
            }

            return new string(odszyfrowanyTekst);
        }


        private string SzyfrPrzesuniecieCykliczne(string input, int przesuniecie)
        {
            // Normalizacja tekstu wejściowego do wielkich liter
            input = input.ToUpper();
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] zaszyfrowanyTekst = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int indexInAlfabet = alfabet.IndexOf(currentChar);

                // Jeśli znak jest literą z alfabetu, zaszyfruj go
                if (indexInAlfabet >= 0)
                {
                    // Oblicz nowy indeks po przesunięciu o k miejsc (modulo 26 dla alfabetu łacińskiego)
                    int newIndex = (indexInAlfabet + przesuniecie) % alfabet.Length;
                    zaszyfrowanyTekst[i] = alfabet[newIndex];
                }
                else
                {
                    // Zostaw znak bez zmian, jeśli nie jest literą
                    zaszyfrowanyTekst[i] = currentChar;
                }
            }

            return new string(zaszyfrowanyTekst);
        }

        private string DeszyfrujPrzesuniecieCykliczne(string input, int przesuniecie)
        {
            // Normalizacja tekstu wejściowego do wielkich liter
            input = input.ToUpper();
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] odszyfrowanyTekst = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int indexInAlfabet = alfabet.IndexOf(currentChar);

                // Jeśli znak jest literą z alfabetu, odszyfruj go
                if (indexInAlfabet >= 0)
                {
                    // Oblicz nowy indeks po przesunięciu w lewo o k miejsc (modulo 26 dla alfabetu łacińskiego)
                    int newIndex = (indexInAlfabet - przesuniecie + alfabet.Length) % alfabet.Length;
                    odszyfrowanyTekst[i] = alfabet[newIndex];
                }
                else
                {
                    // Zostaw znak bez zmian, jeśli nie jest literą
                    odszyfrowanyTekst[i] = currentChar;
                }
            }

            return new string(odszyfrowanyTekst);
        }

        private void Szyfruj_Click(object sender, EventArgs e)
        {
            string tekstJawny = TekstDoSzyfrowania.Text;
            string wynik = "";


            if (checkBoxPrzesuniecieCykliczne.Checked)
            {
                // Pobranie wartości przesunięcia
                if (int.TryParse(textBoxKlucz.Text, out int przesuniecie) && przesuniecie > 0 && przesuniecie < 26)
                {
                    wynik = SzyfrPrzesuniecieCykliczne(tekstJawny, przesuniecie);
                }
                else
                {
                    MessageBox.Show("Wprowadź poprawną liczbę przesunięcia (0 < k < 26)!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (checkBoxPodstawienieHaslem.Checked)
            {
                string klucz = textBoxKlucz.Text;
                if (string.IsNullOrWhiteSpace(klucz))
                {
                    MessageBox.Show("Wprowadź hasło do szyfrowania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                wynik = SzyfrPodstawieniowyZHaslem(tekstJawny, klucz);
            }

            else if (checkBoxProstySzyfr.Checked)
            {
                wynik = ProstySzyfrPodstawieniowy(tekstJawny);  // Zakładamy, że ta metoda jest już zaimplementowana
            }
            else if (checkBoxSzyfrTranspozycyjnym.Checked)
            {

                string kluczTranspozycji = textBoxKlucz.Text;
                wynik = SzyfrTranspozycyjny(tekstJawny, kluczTranspozycji);  // Przykładowe wywołanie
            }
            else
            {
                MessageBox.Show("Brak wybranej opcji szyfrowania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TesktZaszyfrowany.Text = wynik;

        }

        private void btnDeszyfruj_Click(object sender, EventArgs e)
        {
            if (checkBoxProstySzyfr.Checked)
            {
                string zaszyfrowanyTekst = TekstDoSzyfrowania.Text;
                string odszyfrowanyTekst = DeszyfrujProstySzyfrPodstawieniowy(zaszyfrowanyTekst);
                TesktZaszyfrowany.Text = odszyfrowanyTekst;
            }
            else if (checkBoxSzyfrTranspozycyjnym.Checked)
            {
                string zaszyfrowanyTekst = TekstDoSzyfrowania.Text;
                string klucz = textBoxKlucz.Text; // Pobierz klucz z pola tekstowego
                string odszyfrowanyTekst = DeszyfrujSzyfrTranspozycyjny(zaszyfrowanyTekst, klucz);
                TesktZaszyfrowany.Text = odszyfrowanyTekst; // Wyświetl tekst odszyfrowany
            }
            else if (checkBoxPodstawienieHaslem.Checked)
            {
                string zaszyfrowanyTekst = TekstDoSzyfrowania.Text;
                string klucz = textBoxKlucz.Text; // Pobierz klucz z pola tekstowego
                string odszyfrowanyTekst = DeszyfrujPodstawieniowyZHaslem(zaszyfrowanyTekst, klucz);
                TesktZaszyfrowany.Text = odszyfrowanyTekst; // Wyświetl tekst odszyfrowany
            }
            else if (checkBoxPrzesuniecieCykliczne.Checked)
            {
                string zaszyfrowanyTekst = TekstDoSzyfrowania.Text; // Pobierz zaszyfrowany tekst
                int przesuniecie = int.Parse(textBoxKlucz.Text); // Pobierz klucz z pola tekstowego
                string odszyfrowanyTekst = DeszyfrujPrzesuniecieCykliczne(zaszyfrowanyTekst, przesuniecie);
                TesktZaszyfrowany.Text = odszyfrowanyTekst; // Wyświetl tekst odszyfrowany
            }
            else
            {
                MessageBox.Show("Brak wybranej metody szyfrowania/deszyfrowania");
            }
        }
    }
}
