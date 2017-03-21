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

namespace MyFirstWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int laskuri = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, RoutedEventArgs e)
        {
            //Kasvatetaan laskuria
            laskuri++;
            //luetaan textboxin arvo
            string user = txtInput.Text;
            //tervehditään käyttäjää
            txtMessage.Text = "Terve Jaska " + user + " # " + laskuri.ToString();
        }
    }
}
