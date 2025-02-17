using Avalonia.Controls;
using Avalonia.Interactivity;
using LoginTo;
using System;

namespace LoginTo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailBox.Text;
            string password = PasswordBox.Text;

            if (password == "12345")
            {
                var welcomeWindow = new WelcomeWindow(email);
                welcomeWindow.Show();
                this.Close();
            }
            else
            {
                var messageBox = new Window
                {
                    Content = new TextBlock
                    {
                        Text = "Неверный пароль!",
                        Foreground = Avalonia.Media.Brushes.Red,
                        HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                        VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
                    },
                    Width = 300,
                    Height = 100
                };
                messageBox.ShowDialog(this);
            }
        }
    }
}
