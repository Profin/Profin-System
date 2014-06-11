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
//Add
using System.Windows.Controls.Ribbon;
using PresentationLayer.Employees;

namespace PresentationLayer.Main_Forms
{
    /// <summary>
    /// Interaction logic for frmHumanResources.xaml
    /// </summary>
    public partial class frmHumanResources : RibbonWindow
    {
        public frmHumanResources()
        {
            InitializeComponent();
        }

        private void ButtonMaintainEmployees_Click(object sender, RoutedEventArgs e)
        {
            UC_AddEmployee x = new UC_AddEmployee();
            UIPanelHR.Children.Clear();
            UIPanelHR.Children.Add(x);
        }
    }
}
