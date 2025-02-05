using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickOk(object sender, RoutedEventArgs e)
    {
        string text = tbxText.text;
        MessageBox.Show($"Du skrev {text}");
    }
    private void KlickAvbryt(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Du klickade Avbryt");
    }

}