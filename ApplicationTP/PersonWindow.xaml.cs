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
using LogicLayer;

namespace ApplicationTP
{
    /// <summary>
    /// Logique d'interaction pour PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        #region association
        private IPerson p;
        #endregion

        public PersonWindow(IPerson person)
        {
            InitializeComponent();
            this.p = person;
            this.DataContext = p;
            
        }
        
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
