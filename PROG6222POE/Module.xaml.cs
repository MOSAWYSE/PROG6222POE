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
using System.Windows.Shapes;

namespace PROG6222POE
{
    /// <summary>
    /// Interaction logic for Module.xaml
    /// </summary>
    public partial class Module : Window
    {
        public Module()
        {
            InitializeComponent();
        }

        //add module button 
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Module module = new Module();
            moduleData moduleInfo = new moduleData();
            Semester semester = new Semester();

           moduleInfo.saveModule();
            semester.Show();
            module.Close();
        }

        //add semester data


    }
}
