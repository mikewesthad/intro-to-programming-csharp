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

namespace PetPicker
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer player = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();

            ResultsTextBlock.Text = "Howdy from C#";

        }

        private void LionButton_Click(object sender, RoutedEventArgs e)
        {
            ResultsTextBlock.Text = "You picked Lion the duck. Got a great fashion sense.";

            player.Open(new Uri("Sounds/BabySneeze.mp3", UriKind.Relative));
            player.Play();
        }

        private void JuniorButton_Click(object sender, RoutedEventArgs e)
        {
            ResultsTextBlock.Text = "You picked Junior the callback.";
        }
    }
}
