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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

      

        private void btnWithdraw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBal_Click(object sender, RoutedEventArgs e)
        {
            CheckBalance newChkBal = new CheckBalance();
            newChkBal.Show();
            this.Close();
        }

        private void btnLodge_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            LogOutConfirmation lc = new LogOutConfirmation();
            lc.Show(); 
            this.Close();
        }
    }
}
