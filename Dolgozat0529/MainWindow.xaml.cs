using System.Windows;
using System.Windows.Input;

namespace Dolgozat0529
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new Task1Control();
        }

        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new Task2Control();
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new Task3Control();
        }
    }
}
