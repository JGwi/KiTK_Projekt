using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KiTK_Algorytmy
{
    public partial class HuffmanHamingienForm : Form
    {
        public HuffmanHamingienForm()
        {
            InitializeComponent();
        }

        private HuffmanNode currentHuffmanTreeRoot;


        private void ZakHammingabtn_Click(object sender, EventArgs e)
        {
            // Pobierz dane z RichTextBox
            string inputData = DaneBinText.Text.Trim();

            // Sprawdź poprawność danych wejściowych
            if (!IsBinaryString(inputData))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane! Upewnij się, że podano ciąg binarny (0 i 1).",
                                "Błąd danych wejściowych",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Zakodowanie danych Hamminga
            try
            {
                string encodedData = EncodeHamming(inputData);

                // Wyświetlenie wyniku w RichTextBox
                ZakHammingaText.Text = encodedData;
                MessageBox.Show("Dane zostały poprawnie zakodowane kodem Hamminga.",
                                "Sukces",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas kodowania: " + ex.Message,
                                "Błąd",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private bool IsBinaryString(string input)
        {
            return input.All(c => c == '0' || c == '1');
        }

        private string EncodeHamming(string data)
        {
            int m = data.Length;
            int p = 0;

            // Oblicz liczbę bitów parzystości
            while (Math.Pow(2, p) < m + p + 1)
                p++;

            int totalBits = m + p;
            char[] encodedData = new char[totalBits];
            int dataIndex = 0, parityIndex = 0;

            // Wstawianie danych i bitów parzystości
            for (int i = 1; i <= totalBits; i++)
            {
                if (Math.Pow(2, parityIndex) == i)
                {
                    encodedData[i - 1] = '0'; // Tymczasowe bity parzystości
                    parityIndex++;
                }
                else
                {
                    encodedData[i - 1] = data[dataIndex++];
                }
            }

            // Oblicz wartości bitów parzystości
            for (int i = 0; i < p; i++)
            {
                int pos = (int)Math.Pow(2, i);
                int count = 0;

                for (int bitIndex = pos; bitIndex <= totalBits; bitIndex++)
                {
                    if (((bitIndex >> i) & 1) == 1)
                    {
                        if (encodedData[bitIndex - 1] == '1')
                            count++;
                    }
                }

                encodedData[pos - 1] = (count % 2 == 0) ? '0' : '1';
            }

            return new string(encodedData);
        }

        private string DecodeHamming(string encodedData)
        {
            int totalBits = encodedData.Length;
            int p = 0;

            // Oblicz liczbę bitów parzystości
            while (Math.Pow(2, p) < totalBits + 1)
                p++;

            // Znalezienie pozycji błędu
            int errorPosition = 0;

            for (int i = 0; i < p; i++)
            {
                int pos = (int)Math.Pow(2, i);
                int count = 0;

                for (int bitIndex = pos; bitIndex <= totalBits; bitIndex++)
                {
                    if (((bitIndex >> i) & 1) == 1)
                    {
                        if (encodedData[bitIndex - 1] == '1')
                            count++;
                    }
                }

                if (count % 2 != 0)
                    errorPosition += pos;
            }

            // Korygowanie błędu
            if (errorPosition > 0 && errorPosition <= totalBits)
            {
                char[] correctedData = encodedData.ToCharArray();
                correctedData[errorPosition - 1] = correctedData[errorPosition - 1] == '1' ? '0' : '1';
                encodedData = new string(correctedData);

                MessageBox.Show($"Błąd został wykryty i naprawiony na pozycji: {errorPosition}");
            }
            else if (errorPosition > totalBits)
            {
                MessageBox.Show("Wykryto błąd, który nie może zostać naprawiony.");
                return null;
            }

            // Usuwanie bitów parzystości
            StringBuilder decodedData = new StringBuilder();
            int parityIndex = 0;

            for (int i = 1; i <= totalBits; i++)
            {
                if (Math.Pow(2, parityIndex) == i)
                {
                    parityIndex++;
                }
                else
                {
                    decodedData.Append(encodedData[i - 1]);
                }
            }

            return decodedData.ToString();
        }

        private void ZdeHammingabtn_Click(object sender, EventArgs e)
        {
            try
            {
                string input = DaneBinText.Text;

                // Walidacja danych wejściowych
                if (string.IsNullOrWhiteSpace(input) || input.Any(ch => ch != '0' && ch != '1'))
                {
                    MessageBox.Show("Dane wejściowe muszą zawierać tylko cyfry 0 i 1.");
                    return;
                }

                string decoded = DecodeHamming(input);

                if (decoded != null)
                {
                    ZdeHammingaText.Text = decoded;
                    MessageBox.Show("Dane zostały poprawnie zdekodowane.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas dekodowania: {ex.Message}");
            }
        }

        public class HuffmanNode
        {
            public char Character { get; set; }
            public int Frequency { get; set; }
            public HuffmanNode Left { get; set; }
            public HuffmanNode Right { get; set; }
        }

        private Dictionary<char, string> BuildHuffmanTable(HuffmanNode root)
        {
            var table = new Dictionary<char, string>();
            BuildHuffmanTableHelper(root, "", table);
            return table;
        }

        private void BuildHuffmanTableHelper(HuffmanNode node, string code, Dictionary<char, string> table)
        {
            if (node == null) return;

            // Liść
            if (node.Left == null && node.Right == null)
            {
                table[node.Character] = code;
            }

            BuildHuffmanTableHelper(node.Left, code + "0", table);
            BuildHuffmanTableHelper(node.Right, code + "1", table);
        }

        private HuffmanNode BuildHuffmanTree(string input)
        {
            var frequencyDict = input.GroupBy(c => c)
                                      .ToDictionary(g => g.Key, g => g.Count());

            var priorityQueue = new SortedSet<HuffmanNode>(
                frequencyDict.Select(kvp => new HuffmanNode { Character = kvp.Key, Frequency = kvp.Value }),
                Comparer<HuffmanNode>.Create((x, y) =>
                    x.Frequency == y.Frequency ? x.Character.CompareTo(y.Character) : x.Frequency.CompareTo(y.Frequency))
            );

            while (priorityQueue.Count > 1)
            {
                var left = priorityQueue.Min;
                priorityQueue.Remove(left);
                var right = priorityQueue.Min;
                priorityQueue.Remove(right);

                var newNode = new HuffmanNode
                {
                    Character = '\0',
                    Frequency = left.Frequency + right.Frequency,
                    Left = left,
                    Right = right
                };

                priorityQueue.Add(newNode);
            }

            return priorityQueue.First();
        }

        private string EncodeHuffman(string input, Dictionary<char, string> huffmanTable)
        {
            return string.Join("", input.Select(c => huffmanTable[c]));
        }

        private string DisplayHuffmanTree(HuffmanNode node, int level = 0)
        {
            if (node == null)
                return "";

            string indent = new string(' ', level * 4); // Wcięcie dla hierarchii
            string result = "";

            if (node.Left == null && node.Right == null)
            {
                // Liść: wyświetl znak i częstotliwość
                result += $"{indent}• '{node.Character}' ({node.Frequency})\n";
            }
            else
            {
                // Węzeł wewnętrzny: wyświetl sumę częstotliwości
                result += $"{indent}• ({node.Frequency})\n";
            }

            // Rekursywnie przejdź do lewego i prawego poddrzewa
            result += DisplayHuffmanTree(node.Left, level + 1);
            result += DisplayHuffmanTree(node.Right, level + 1);

            return result;
        }


        private void ZakHuffmanabtn_Click(object sender, EventArgs e)
        {
            try
            {
                string input = DaneText.Text;

                // Walidacja danych wejściowych
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Wprowadź tekst do zakodowania.");
                    return;
                }

                // Budowa drzewa Huffmana
                HuffmanNode root = BuildHuffmanTree(input);


                // Tworzenie tablicy kodowania
                var huffmanTable = BuildHuffmanTable(root);

                // Kodowanie tekstu
                string encodedText = EncodeHuffman(input, huffmanTable);

                // Wyświetlenie wyników kodowania
                ZakHuffmanaText.Text = encodedText;

                // Wyświetlenie drzewa Huffmana
                DrzewoHuffmanaText.Text = DisplayHuffmanTree(root);

                MessageBox.Show("Tekst został pomyślnie zakodowany kodem Huffmana.\nDrzewo Huffmana zostało wygenerowane.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas kodowania Huffmana: {ex.Message}");
            }
        }


        private string DecodeHuffman(string encodedText, HuffmanNode root)
        {
            StringBuilder decodedText = new StringBuilder();
            HuffmanNode currentNode = root;

            foreach (char bit in encodedText)
            {
                if (bit == '0')
                    currentNode = currentNode.Left;
                else if (bit == '1')
                    currentNode = currentNode.Right;
                else
                    throw new ArgumentException("Zakodowany tekst zawiera nieprawidłowe znaki.");

                // Gdy dotrzesz do liścia, dodaj znak i wróć do korzenia
                if (currentNode.Left == null && currentNode.Right == null)
                {
                    decodedText.Append(currentNode.Character);
                    currentNode = root;
                }
            }

            return decodedText.ToString();
        }


       

        private void ZdeHuffmanabtn_Click(object sender, EventArgs e)
        {
            try
            {
                string encodedText = DaneText.Text;

                // Walidacja danych wejściowych
                if (string.IsNullOrWhiteSpace(encodedText))
                {
                    MessageBox.Show("Wprowadź zakodowany tekst do zdekodowania.");
                    return;
                }

                if (currentHuffmanTreeRoot == null)
                {
                    MessageBox.Show("Nie znaleziono drzewa Huffmana. Upewnij się, że tekst został wcześniej zakodowany.");
                    return;
                }

                // Dekodowanie
                string decodedText = DecodeHuffman(encodedText, currentHuffmanTreeRoot);

                // Wyświetlenie wyników dekodowania
                ZdeHuffmanaText.Text = decodedText;
                MessageBox.Show("Tekst został pomyślnie zdekodowany.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas dekodowania Huffmana: {ex.Message}");
            }
        }
    }
}
