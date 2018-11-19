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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ATM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        Card myCard = new Card("1234 5678 9101", "1234", DateTime.Now.AddYears(2), 000, CardType.DEBIT);
        

        public Login()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            System.Windows.Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //create Log In session
            LogInProcess myLogIn = new LogInProcess();
            myLogIn.InsertCard(myCard);
            //myLogIn.LogIn(txtPWord.Text.ToString());

            if (myLogIn.LogIn(txtPWord.Text.ToString()))
            {
                //If login successful allow access to main menu
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Close();
            }
            else
                txtPWord.Text = "Wrong Pin";
        }


    }
}
