using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using LogicLayer;
using Serialization;

namespace ApplicationTP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region associations
        private Directory directory;
        private IStorage storage;
        #endregion

        public MainWindow()
        {
            storage = new JsonStorage();
            directory = storage.Load();
            InitializeComponent();
            
            PrintList();
        }

        private void PrintList()
        {
            contacts.Items.Clear(); // clear existings items
            Person[] list = directory.ListContacts();
            foreach (Person p in list)
            {
                contacts.Items.Add(new PersonIHM(p));
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            PersonIHM p = new PersonIHM(new Person("", ""));
            PersonWindow fen = new PersonWindow((IPerson)p);
            if (fen.ShowDialog() == true)
            {
                directory.NewContact(p.Personne);
            }
            PrintList();
            storage.Update(p.Personne);
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (contacts.SelectedItem is PersonIHM p)
            {
                storage.Delete(p.Personne);
                PrintList();
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            if (contacts.SelectedItem is PersonIHM p)
            {
                PersonIHM TempP = (PersonIHM)p.Clone();
                PersonWindow fen = new PersonWindow((IPerson)TempP);
                if (fen.ShowDialog() == true)
                {
                    p.Copy(TempP);
                }
                PrintList();
                storage.Update(p.Personne);
            }
        }
    }
}
