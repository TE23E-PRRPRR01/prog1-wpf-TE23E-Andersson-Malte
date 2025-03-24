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

namespace OmvändTextApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickVändOm(object sender, RoutedEventArgs e)
    {
        //Variabler
        int antalTecken = 0;
        string vändText = "";
        
        //Läs in texten
        string text = txbInput.Text;

        //Vänd på texten
        for (int i = text.Length-1; i >= 0; i--)
        {
            vändText += text[i];
        }

        // Skriv ut i textruta
        txbOutput.Text = vändText;

        // Räkna upp antal total tecken
        antalTecken = vändText.Length;

        // Skriv ut totalt antal tecken
        txbAntalTecken.Text = $"Antal tecken: {antalTecken}";

    }
}
