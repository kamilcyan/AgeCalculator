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

namespace Age
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dpick_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = dpick.SelectedDate.Value;
            DateTime current = DateTime.Now;
            Date dateFromClass = new Date(date, current);

            double seconds = dateFromClass.DateCounter();
            double Hours = dateFromClass.DateCounter()/3600;
            double Days = dateFromClass.DateCounter()/86400;

            SecondText.Text = seconds.ToString();
            HoursText.Text = Hours.ToString();
            DaysText.Text = Days.ToString();
        }
    }
}
