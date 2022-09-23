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
        private IPerson temp,person;
        #endregion

        public PersonWindow(IPerson person)
        {
            InitializeComponent();
            temp = (IPerson)person.Clone();
            this.person = person;
            this.DataContext = temp;
            
        }
        
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            person.Copy(temp);
            this.DialogResult = true;
        }
    }
}
