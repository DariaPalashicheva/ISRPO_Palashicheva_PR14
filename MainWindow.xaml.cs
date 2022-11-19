﻿using ISRPO_Palashicheva_PR14.ApplicationData;
using ISRPO_Palashicheva_PR14.PageMain;
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

namespace ISRPO_Palashicheva_PR14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.modelOdb = new KitchenEntities(); // соед с бд
            AppFrame.FrameMain = myFrame; // загрузка фрейма со стартом
            myFrame.Navigate(new PageTovars());
        }
    }
}
