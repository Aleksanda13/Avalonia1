using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LoginTo;

public partial class WelcomeWindow : Window
{
    public WelcomeWindow(string email)
    {
        InitializeComponent();
        EmailText.Text = $"Ваш email: {email}";
    }

}
