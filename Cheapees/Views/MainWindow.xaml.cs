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
using System.Threading;

namespace Cheapees
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {


    public MainWindow()
    {
      InitializeComponent();

      //run product category for all of our ASINs
      //AmzFunctions func = new AmzFunctions();
      //var asins = func.GetProductCategories(func.GetAsinList());

      
      StatusView statusView = new StatusView();
      tabStatus.Content = statusView;

      DataView dataView = new DataView();
      tabData.Content = dataView;
    }
  }
}
