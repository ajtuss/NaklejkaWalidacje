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
using DYMO.Label.Framework;

namespace NaklejkaWalidacje
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dateTest.SelectedDate = DateTime.Now;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var label = DYMO.Label.Framework.Label.Open("Naklejka.label");
            label.SetObjectText("DATETEST", dateTest.Text);
            label.SetObjectText("DATETEST2", dateTest2.Text);
            label.SetObjectText("MARKA", txtMarka.Text);
            label.SetObjectText("MODEL", txtModel.Text);
            label.SetObjectText("SN", txtSn.Text);
            label.SetObjectText("PROT", txtProt.Text);
            label.Print("DYMO LabelWriter 450");

        }

        private void dateTest_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = (DateTime) dateTest.SelectedDate;
            dateTest2.SelectedDate = date.AddYears(1);
        }
    }
}
