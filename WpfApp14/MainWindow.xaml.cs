using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace WpfApp14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Human EditHuman { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            EditHuman = new Human { Name = "Петя", Age = 20 };
            DataContext = this;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp server";
            client.Port = 25; // "smtp port";
            client.EnableSsl = false;
            client.Credentials = new NetworkCredential("логин", "пароль");
            client.Send("от кого", "кому", "тема", "лох");
        }
    }
}
