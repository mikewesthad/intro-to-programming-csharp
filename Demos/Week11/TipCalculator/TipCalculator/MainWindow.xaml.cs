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
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
 * Last time, we created the content and appearance of our app in XAML. Today, we're going to implement
 * the functionality in C# "code-behind" that is associated with the XAML.
 * 
 * 1. Learn how to get and set Text from a Textbox and Textblock
 * 2. Display the total with tip when the calculate button is pressed.
 * 3. Format the tip so that it looks nice "$20.15", remember:
 *      https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#the-currency-c-format-specifier
 * 4. Improve the user experience. What happens if omits the tip or the total? What if they enter Letters?
 * 5. Add a clear button that resets the calculator - clearing the results and the textboxes.
 * 6. Technically... people tip based on subtotal, not the total. Add a way for the user to enter subtotal, tax and tip separately.
 * 7. (Advanced) The interface could be nicer if there were a dropdown for selecting the tip amount, rather than entering it manually:
 *      https://www.c-sharpcorner.com/UploadFile/mahesh/wpf-combobox/
 */

namespace TipCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // This pops up a modal window and pauses our WPF application until the message box is closed.
            //MessageBox.Show("You clicked me!");

            string tipText = TipTextBox.Text;
            string totalText = TotalTextBox.Text;

            // Error checking: make sure neither textbox is blank.
            if (tipText == String.Empty || totalText == String.Empty)
            {
                MessageBox.Show("You need to enter something for tip and total!");
                return;
            }

            // Error checking: perform the "unsafe" operation of converting a string to a double in
            // a try-catch statement. This lets us gracefully handle the situation where the user
            // mistypes and includes non-numeric characters in the boxes, like"2e3".
            double tip;
            double total;
            double totalWithTip;
            try
            {
                tip = Convert.ToDouble(tipText);
                total = Convert.ToDouble(totalText);
                totalWithTip = total + total * (tip / 100.0);
            }
            catch
            {
                MessageBox.Show("You entered something that wasn't a number!");
                return;
            }

            ResultTextBlock.Text = totalWithTip.ToString("C2");
        }
    }
}
