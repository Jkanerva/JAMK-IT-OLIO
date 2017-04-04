using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Lotto lotto;

        public MainPage()
        {
            this.InitializeComponent();
            lotto = new Lotto();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            int rows;
            bool result = int.TryParse(rowsTextBox.Text, out rows);
            if (result)
            {
                if (rows > 0) RandomizeNumbers(rows);
                else
                {
                    Debug.WriteLine("Amount of lottery rows to draw needs to be a number!");
                }
            }
            else
            {
                Debug.WriteLine("Amount of lottery rows to draw can't be negative!");
            }
        }

        private void RandomizeNumbers(int rows)
        {
            string numbersString = "";
            for (int i = 1; i <= rows; i++)
            {
                // get random numbers by selected lottery type
                List<int> numbers = lotto.getRandomNumbers(lottoComboBox.SelectedValue.ToString());
                numbersString += "Row " + i + ": ";
                for (int j = 0; j < numbers.Count; j++)
                {
                    numbersString += numbers[j] + " ";
                }
                numbersString += Environment.NewLine;
            }
            numbersTextBlock.Text = numbersString;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numbersTextBlock.Text = "";
        }
    }
}
