/*
 * Created by SharpDevelop.
 * User: Sergey
 * Date: 16.12.2019
 * Time: 21:32
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

namespace Transformation2D
{
	/// <summary>
	/// Interaction logic for ObjectMatrixTransformations.xaml
	/// </summary>
	public partial class ObjectMatrixTransformations : Window
	{
		public ObjectMatrixTransformations()
		{
			InitializeComponent();
		}
		
		void ButtonApply_Click(object sender, RoutedEventArgs e)
		{
			Matrix m = new Matrix();
			m.M11 = Double.Parse(tbM11.Text);
			m.M12 = Double.Parse(tbM12.Text);
			m.M21 = Double.Parse(tbM21.Text);
			m.M22 = Double.Parse(tbM22.Text);
			m.OffsetX = Double.Parse(tbOffsetX.Text);
			m.OffsetY = Double.Parse(tbOffsetY.Text);
			matrixTransform.Matrix = m;
		}
		
		void ButtonClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}