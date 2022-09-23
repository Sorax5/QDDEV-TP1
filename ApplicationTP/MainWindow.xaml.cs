﻿using System;
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
using LogicLayer;

namespace ApplicationTP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region associations
        private Directory directory;
        #endregion
        
        public MainWindow()
        {
            directory = new Directory();
            InitializeComponent();
            directory.NewContact(new Person("harris", "steve", GenderType.MALE));
            directory.NewContact(new Person("dickinson", "bruce"));
            directory.NewContact(new Person("murray", "dave", GenderType.FEMALE));
            directory.NewContact(new Person("smith", "adrian", GenderType.MALE));
            directory.NewContact(new Person("gers", "jannick"));
            directory.NewContact(new Person("mc brain", "nicko",GenderType.FEMALE));
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
            Person p = new Person("", "");
            PersonWindow fen = new PersonWindow(p);
            if (fen.ShowDialog() == true)
            {
                directory.NewContact(p);
            }
            PrintList();

        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (contacts.SelectedItem is PersonIHM p)
            {
                directory.RemoveContact(p.Personne);
                PrintList();
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            if (contacts.SelectedItem is IPerson p)
            {
                IPerson TempP = (IPerson)p.Clone();
                PersonWindow fen = new PersonWindow(TempP);
                if (fen.ShowDialog() == true)
                {
                    p.Copy(TempP);
                }
                PrintList();
            }
        }
    }
}
