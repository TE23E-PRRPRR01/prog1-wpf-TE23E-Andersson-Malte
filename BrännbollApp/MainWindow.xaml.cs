using System.Net.Http.Headers;
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

namespace BrännbollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    //Skapa variablerna 
    int poängInne = 0;
    int poängUte = 0;

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {
        //Lägg till 5
        poängInne += 5;

        tbxInne.Text = $"{poängInne}";

         //Vad är klockan just nu?
        DateTime nu = DateTime.Now;

        tbxHistorik.Text += $"\n {nu.ToString("HH:mm:ss")} Lag inne: +5 frivarv | Totalt: {poängInne}";
    }

    private void KlickBränning(object sender, RoutedEventArgs e)
    {
        //Lägg till 2
        poängUte += 2;

        tbxUte.Text = $"{poängUte}";

         //Vad är klockan just nu?
        DateTime nu = DateTime.Now;

        tbxHistorik.Text += $"\n {nu.ToString("HH:mm:ss")} Lag ute: +2 bränning | Totalt: {poängUte}";
    }

    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        //Lägg till 3   
        poängUte += 3;

        tbxUte.Text = $"{poängUte}";

         //Vad är klockan just nu?
        DateTime nu = DateTime.Now;

        tbxHistorik.Text += $"\n {nu.ToString("HH:mm:ss")} Lag ute: +3 lyra | Totalt: {poängUte}";
    }

    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        //Lägg till 1
        poängInne += 1;

        tbxInne.Text = $"{poängInne}";

        //Vad är klockan just nu?
        DateTime nu = DateTime.Now;

        tbxHistorik.Text += $"\n {nu.ToString("HH:mm:ss")} Lag inne: +1 varv | Totalt: {poängInne}";
    }
}