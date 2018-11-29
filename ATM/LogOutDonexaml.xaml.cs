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
    /// Interaction logic for LogOutDonexaml.xaml
    /// </summary>
    public partial class LogOutDonexaml : Window
    {

        public LogOutDonexaml()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 10000;
            t.Elapsed += t_Elapsed;
            t.AutoReset = false; 
            t.Enabled = true; 
        }
        public void t_Elapsed (Object source, System.Timers.ElapsedEventArgs e)
        {
            
            this.Close();  
        }
    }
}
