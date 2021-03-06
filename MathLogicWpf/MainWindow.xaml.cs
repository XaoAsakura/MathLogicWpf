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
using MahApps.Metro.Controls;

namespace MathLogicWpf
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : MetroWindow
	{
		public static MetroWindow LastInstance { get; private set; }

		public MainWindow()
		{
			InitializeComponent();
			LastInstance = this;
		}

		private void MetroWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			transitioning.Content = bool.Parse(e.NewValue.ToString()) ? new MainFrame() : null;
		}
	}
}
