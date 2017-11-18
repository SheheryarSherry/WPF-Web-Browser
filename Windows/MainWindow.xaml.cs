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
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Net;
using fyp.Bookmarks;
using System.Windows.Shell;

namespace fyp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool Maximized;
        private AddBookmark Addbook;
        public List<TabView> Pages;
        private WebClient DLUpdate;
        private WebClient JsonDownload;

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}