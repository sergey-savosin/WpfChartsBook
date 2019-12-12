/*
 * Created by SharpDevelop.
 * User: Sergey
 * Date: 06.12.2019
 * Time: 21:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Chapter01
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		void TextBox_OnTextChanged(object sender, TextChangedEventArgs e)
		{
			textBlock.Text = textBox.Text;
		}
		void ButtonChangeColor_OnClick(object sender, RoutedEventArgs e)
		{
			if (textBlock.Foreground == Brushes.Black)
				textBlock.Foreground = Brushes.Red;
			else
				textBlock.Foreground = Brushes.Black;
		}
		void ButtonChangeSize_OnClick(object sender, RoutedEventArgs e)
		{
			if (textBlock.FontSize == 11)
				textBlock.FontSize = 24;
			else
				textBlock.FontSize = 11;
		}
	}
}