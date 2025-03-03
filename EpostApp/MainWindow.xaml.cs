using System.Net;
using System.Net.Mail;
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

using System.Text.RegularExpressions;

namespace EpostApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        //Läs av epost och meddelanden
        string epost = tbxEpost.Text;
        string meddelande = tbxMeddelande.Text;

        //Koppla upp på en mail-server
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.Credentials = new NetworkCredential("user", "pass");

        //Sanity check
        if (epost != "" & meddelande != "")
        {
            smtp.Send("greger@gmail.com", epost, "Epost från appen", meddelande);
            lblStatus.Content = "Ok";
        }
        else
        {
            lblStatus.Content = "Fel! Något av fälten är tomma!";
        }
    }

    private void ChangedEpost(object sender, RoutedEventArgs e)
    {
        string epost = tbxEpost.Text;

        string regexEpost = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        if (!Regex.IsMatch(epost, regexEpost))
        {
            // Visa felmeddelande
            lblStatus.Text = "Du måste ange en giltig epostadress!";
        }
        else
        {
    }
    }
}