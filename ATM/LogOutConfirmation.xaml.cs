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
using System.Windows.Shapes;

namespace ATM
{
    /// <summary>
    /// Interaction logic for LogOutConfirmation.xaml
    /// </summary>
    public partial class LogOutConfirmation : Window
    {
        public LogOutConfirmation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //No button Click on Log Out
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close(); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LogOutDonexaml lod = new LogOutDonexaml();
            lod.Show();
            this.Close(); 
        }
    }
}
