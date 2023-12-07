using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace CC_Checker_app
{
    /// <summary>
    /// Interaction logic for ValidatorWindow.xaml
    /// </summary>
    public partial class ValidatorWindow : Window
    {
        public ValidatorWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String cardno = Card_no.Text;
            bool validity = IsValidCard(cardno);
            if (validity) { MessageBox.Show("Card is Valid"); }
            else
            {
                MessageBox.Show("Card Is not Valid");
            }
        }
        private static bool IsValidCard(String card_no)
        {
            int sum = 0;
            for (int i = card_no.Length - 1; i >= 0; i--)
            {
                int num = card_no[i] - '0';
                if (i % 2 != 0)
                {
                    sum += num;
                }
                else
                {
                    num = num * 2;
                    if (num > 9)
                    {
                        int dsum = num / 10;
                        dsum += num % 10;
                        sum += dsum;
                    }
                    else
                    {
                        sum += num;
                    }
                }
            }

            return (sum % 10 == 0) ? true : false;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Card_no.Clear();
        }
    }
}
