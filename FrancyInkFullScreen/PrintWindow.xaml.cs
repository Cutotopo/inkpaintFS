using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FrancyInkFullScreen
{
    /// <summary>
    /// Logica di interazione per PrintWindow.xaml
    /// </summary>
    public partial class PrintWindow : Window
    {
        public PrintWindow()
        {
            InitializeComponent();
        }

        private void Thickness15(object sender, RoutedEventArgs e)
        {
            Anteprima.DefaultDrawingAttributes.Width = 5;
            Anteprima.DefaultDrawingAttributes.Height = 5;
        }

        private void Thickness20(object sender, RoutedEventArgs e)
        {
            Anteprima.DefaultDrawingAttributes.Width = 10;
            Anteprima.DefaultDrawingAttributes.Height = 10;
        }

        private void Thickness25(object sender, RoutedEventArgs e)
        {
            Anteprima.DefaultDrawingAttributes.Width = 15;
            Anteprima.DefaultDrawingAttributes.Height = 15;
        }

        private void ColoreNero(object sender, RoutedEventArgs e)
        {
            Anteprima.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void ColoreVerde(object sender, RoutedEventArgs e)
        {
            Anteprima.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void ColoreBlu(object sender, RoutedEventArgs e)
        {
            Anteprima.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Impossibile trovare la stampante", "FrancyINK");
        }

        private void SalvaAnteprima(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "File di FrancyINK (*.fink)|*.fink";

            if (saveFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                System.Windows.Ink.StrokeCollection strokes = Anteprima.Strokes;
                strokes.Save(fs);
                fs.Close();
            }
        }

        private void ApriAnteprima(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File di FrancyINK (*.fink)|*.fink";

            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,
                                               FileMode.Open);
                Anteprima.Strokes = new StrokeCollection(fs);
                fs.Close();
            }
        }
    }
}
