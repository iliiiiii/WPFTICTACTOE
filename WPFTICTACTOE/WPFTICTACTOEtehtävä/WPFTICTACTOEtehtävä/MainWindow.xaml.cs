using System.Windows;
using System.Windows.Controls;

namespace WPFTICTACTOEtehtävä
{
    public partial class MainWindow : Window
    {
        private bool playerXTurn = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Content == null)
            {
                button.Content = playerXTurn ? "X" : "O";
                playerXTurn = !playerXTurn;
                
            }
        }
    }
}
