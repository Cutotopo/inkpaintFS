using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FrancyInkFullScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("HH:mm:ss");
        }
        

        private void Thickness10(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Width = 1;
            FrancyINK.DefaultDrawingAttributes.Height = 1;
        }

        private void Thickness15(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Width = 5;
            FrancyINK.DefaultDrawingAttributes.Height = 5;
        }

        private void Thickness20(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Width = 10;
            FrancyINK.DefaultDrawingAttributes.Height = 10;
        }

        private void Thickness25(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Width = 15;
            FrancyINK.DefaultDrawingAttributes.Height = 15;
        }

        private void Thickness30(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Width = 20;
            FrancyINK.DefaultDrawingAttributes.Height = 20;
        }

        private void Thickness35(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Width = 25;
            FrancyINK.DefaultDrawingAttributes.Height = 25;
        }

        private void Thickness40(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Width = 30;
            FrancyINK.DefaultDrawingAttributes.Height = 30;
        }

        private void Thickness45(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Width = 35;
            FrancyINK.DefaultDrawingAttributes.Height = 35;
        }

        private void Thickness50(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Width = 40;
            FrancyINK.DefaultDrawingAttributes.Height = 40;
        }

        private void ColoreNero(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void ColoreRosso(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void ColoreVerde(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void ColoreBlu(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void ColoreGiallo(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void ColoreBianco(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void ResInfo(object sender, RoutedEventArgs e)
        {
            ResErr err = new ResErr();
            err.Show();
        }

        private void ZoomIn(object sender, RoutedEventArgs e)
        {
            Matrix m = new Matrix();
            m.Scale(1.1d, 1.1d);
            ((InkCanvas)FrancyINK).Strokes.Transform(m, true);

        }
        
        private void ZoomOut(object sender, RoutedEventArgs e)
        {
            Matrix m = new Matrix();
            m.Scale(0.9d, 0.9d);
            ((InkCanvas)FrancyINK).Strokes.Transform(m, true);
        }

        private void Apri(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File di FrancyINK (*.fink)|*.fink";

            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,
                                               FileMode.Open);
                FrancyINK.Strokes = new StrokeCollection(fs);
                fs.Close();
            }

            String timeStamp = GetTimestamp(DateTime.Now);
            UltimoEventoTipo.Content = "Tavola caricata da file";
            UltimoEventoOra.Content = timeStamp;
            EventoTipo.Content = "Tavola caricata da file";
            EventoDurata.Content = "1 secondo fa";
            var timer4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer4.Start();
            timer4.Tick += (sender, args) =>
            {
                timer4.Stop();
                EventoDurata.Content = "2 secondi fa";
            };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                EventoDurata.Content = "3 secondi fa";
            };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                EventoDurata.Content = "4 secondi fa";
            };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                EventoDurata.Content = "5 secondi fa";
            };
            timerend.Start();
            timerend.Tick += (sender, args) =>
            {
                timerend.Stop();
                EventoTipo.Content = "Nessun evento da mostrare";
                EventoDurata.Content = "";
            };
        }

            private void Esci(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Salva(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "File di FrancyINK (*.fink)|*.fink";

            if (saveFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                System.Windows.Ink.StrokeCollection strokes = FrancyINK.Strokes;
                strokes.Save(fs);
                fs.Close();
            }
            String timeStamp = GetTimestamp(DateTime.Now);
            UltimoEventoTipo.Content = "Tavola salvata";
            UltimoEventoOra.Content = timeStamp;
            EventoTipo.Content = "Tavola salvata";
            EventoDurata.Content = "1 secondo fa";
            var timer4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer4.Start();
            timer4.Tick += (sender, args) =>
            {
                timer4.Stop();
                EventoDurata.Content = "2 secondi fa";
            };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                EventoDurata.Content = "3 secondi fa";
            };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                EventoDurata.Content = "4 secondi fa";
            };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                EventoDurata.Content = "5 secondi fa";
            };
            timerend.Start();
            timerend.Tick += (sender, args) =>
            {
                timerend.Stop();
                EventoTipo.Content = "Nessun evento da mostrare";
                EventoDurata.Content = "";
            };

        }

        private void EliminaTutto(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("La tavola verrà eliminata. Continuare?", "FrancyINK", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    FrancyINK.Strokes.Clear();

                    break;
                case MessageBoxResult.No:
                    break;
            }
            String timeStamp = GetTimestamp(DateTime.Now);
            UltimoEventoTipo.Content = "Tavola eliminata";
            UltimoEventoOra.Content = timeStamp;
            EventoTipo.Content = "Tavola eliminata";
            EventoDurata.Content = "1 secondo fa";
            var timer4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer4.Start();
            timer4.Tick += (sender, args) =>
            {
                timer4.Stop();
                EventoDurata.Content = "2 secondi fa";
            };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                EventoDurata.Content = "3 secondi fa";
            };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                EventoDurata.Content = "4 secondi fa";
            };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                EventoDurata.Content = "5 secondi fa";
            };
            timerend.Start();
            timerend.Tick += (sender, args) =>
            {
                timerend.Stop();
                EventoTipo.Content = "Nessun evento da mostrare";
                EventoDurata.Content = "";
            };
        }
        private void Evidenzia(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.IsHighlighter = true;
        }
        private void NoEvidenzia(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.IsHighlighter = false;
        }
        private void ApriImmagine(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                ImageControl.Source = new BitmapImage(fileUri);
                PercorsoFile.Content = fileUri;
                PercorsoFileMenu.Header = fileUri;
            }
            String timeStamp = GetTimestamp(DateTime.Now);
            UltimoEventoTipo.Content = "Sfondo caricato da file";
            UltimoEventoOra.Content = timeStamp;
            EventoTipo.Content = "Sfondo caricato da file";
            EventoDurata.Content = "1 secondo fa";
            var timer4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer4.Start();
            timer4.Tick += (sender, args) =>
            {
                timer4.Stop();
                EventoDurata.Content = "2 secondi fa";
            };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                EventoDurata.Content = "3 secondi fa";
            };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                EventoDurata.Content = "4 secondi fa";
            };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                EventoDurata.Content = "5 secondi fa";
            };
            timerend.Start();
            timerend.Tick += (sender, args) =>
            {
                timerend.Stop();
                EventoTipo.Content = "Nessun evento da mostrare";
                EventoDurata.Content = "";
            };
        }

        private void ApriImmagineMenu(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                ImageControl.Source = new BitmapImage(fileUri);
                PercorsoFileMenu.Header = fileUri;
                PercorsoFile.Content = fileUri;
            }
            String timeStamp = GetTimestamp(DateTime.Now);
            UltimoEventoTipo.Content = "Sfondo caricato da file";
            UltimoEventoOra.Content = timeStamp;
            EventoTipo.Content = "Sfondo caricato da file";
            EventoDurata.Content = "1 secondo fa";
            var timer4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer4.Start();
            timer4.Tick += (sender, args) =>
            {
                timer4.Stop();
                EventoDurata.Content = "2 secondi fa";
            };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                EventoDurata.Content = "3 secondi fa";
            };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                EventoDurata.Content = "4 secondi fa";
            };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                EventoDurata.Content = "5 secondi fa";
            };
            timerend.Start();
            timerend.Tick += (sender, args) =>
            {
                timerend.Stop();
                EventoTipo.Content = "Nessun evento da mostrare";
                EventoDurata.Content = "";
            };

        }

        private void EvidenziatoreRosso(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.IsHighlighter = true;
            FrancyINK.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void EvidenziatoreVerde(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.IsHighlighter = true;
            FrancyINK.DefaultDrawingAttributes.Color = Colors.Green;
        }
        
        private void EvidenziatoreGiallo(object sender, RoutedEventArgs e)
        {
            FrancyINK.DefaultDrawingAttributes.IsHighlighter = true;
            FrancyINK.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void SalvaLR(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "File di FrancyINK a bassa risoluzione (*.lrfink)|*.lrfink";

            if (saveFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                System.Windows.Ink.StrokeCollection strokes = FrancyINK.Strokes;
                strokes.Save(fs);
                fs.Close();
            }
            String timeStamp = GetTimestamp(DateTime.Now);
            UltimoEventoTipo.Content = "Tavola salvata a bassa risoluzione";
            UltimoEventoOra.Content = timeStamp;
            EventoTipo.Content = "Tavola salvata a bassa risoluzione";
            EventoDurata.Content = "1 secondo fa";
            var timer4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer4.Start();
            timer4.Tick += (sender, args) =>
            {
                timer4.Stop();
                EventoDurata.Content = "2 secondi fa";
            };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                EventoDurata.Content = "3 secondi fa";
            };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                EventoDurata.Content = "4 secondi fa";
            };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                EventoDurata.Content = "5 secondi fa";
            };
            timerend.Start();
            timerend.Tick += (sender, args) =>
            {
                timerend.Stop();
                EventoTipo.Content = "Nessun evento da mostrare";
                EventoDurata.Content = "";
            };


        }

        private void StampaRapida(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Impossibile trovare la stampante", "FrancyINK");
            String timeStamp = GetTimestamp(DateTime.Now);
            UltimoEventoTipo.Content = "Stampa rapida fallita";
            UltimoEventoOra.Content = timeStamp;
            EventoTipo.Content = "Stampa rapida fallita";
            EventoDurata.Content = "1 secondo fa";
            var timer4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer4.Start();
            timer4.Tick += (sender, args) =>
            {
                timer4.Stop();
                EventoDurata.Content = "2 secondi fa";
            };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                EventoDurata.Content = "3 secondi fa";
            };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                EventoDurata.Content = "4 secondi fa";
            };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                EventoDurata.Content = "5 secondi fa";
            };
            timerend.Start();
            timerend.Tick += (sender, args) =>
            {
                timerend.Stop();
                EventoTipo.Content = "Nessun evento da mostrare";
                EventoDurata.Content = "";
            };

        }

        private void Stampa(object sender, RoutedEventArgs e)
        {
            PrintWindow stampa = new PrintWindow();
            stampa.Show();
            String timeStamp = GetTimestamp(DateTime.Now);
            UltimoEventoTipo.Content = "Aperta finestra di stampa";
            UltimoEventoOra.Content = timeStamp;
            EventoTipo.Content = "Aperta finestra di stampa";
            EventoDurata.Content = "1 secondo fa";
            var timer4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer4.Start();
            timer4.Tick += (sender, args) =>
            {
                timer4.Stop();
                EventoDurata.Content = "2 secondi fa";
            };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                EventoDurata.Content = "3 secondi fa";
            };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                EventoDurata.Content = "4 secondi fa";
            };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                EventoDurata.Content = "5 secondi fa";
            };
            timerend.Start();
            timerend.Tick += (sender, args) =>
            {
                timerend.Stop();
                EventoTipo.Content = "Nessun evento da mostrare";
                EventoDurata.Content = "";
            };

        }

        private void RimuoviImmagine(object sender, RoutedEventArgs e)
        {
            ImageControl.Source = new BitmapImage();
            PercorsoFileMenu.Header = "Immagine rimossa (5)";
            PercorsoFile.Content = "   Immagine rimossa (5)   ";
            String timeStamp = GetTimestamp(DateTime.Now);
            var timerA4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timerA3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timerA2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timerA1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerAend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timerA4.Start();
            timerA4.Tick += (sender, args) =>
            {
                timerA4.Stop();
                PercorsoFileMenu.Header = "Immagine rimossa (4)";
                PercorsoFile.Content = "   Immagine rimossa (4)   ";
            };
            timerA3.Start();
            timerA3.Tick += (sender, args) =>
            {
                timerA3.Stop();
                PercorsoFileMenu.Header = "Immagine rimossa (3)";
                PercorsoFile.Content = "   Immagine rimossa (3)   ";
            };
            timerA2.Start();
            timerA2.Tick += (sender, args) =>
            {
                timerA2.Stop();
                PercorsoFileMenu.Header = "Immagine rimossa (2)";
                PercorsoFile.Content = "   Immagine rimossa (2)   ";
            };
            timerA1.Start();
            timerA1.Tick += (sender, args) =>
            {
                timerA1.Stop();
                PercorsoFileMenu.Header = "Immagine rimossa (1)";
                PercorsoFile.Content = "   Immagine rimossa (1)   ";
            };
            timerAend.Start();
            timerAend.Tick += (sender, args) =>
            {
                timerAend.Stop();
                PercorsoFileMenu.Header = "Nessuna immagine caricata";
                PercorsoFile.Content = "   Nessun file aperto   ";
            };

            UltimoEventoTipo.Content = "Immagine di sfondo rimossa";
            UltimoEventoOra.Content = timeStamp;
            EventoTipo.Content = "Immagine di sfondo rimossa";
            EventoDurata.Content = "1 secondo fa";
            var timer4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer4.Start();
            timer4.Tick += (sender, args) =>
            {
                timer4.Stop();
                EventoDurata.Content = "2 secondi fa";
            };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                EventoDurata.Content = "3 secondi fa";
            };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                EventoDurata.Content = "4 secondi fa";
            };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                EventoDurata.Content = "5 secondi fa";
            };
            timerend.Start();
            timerend.Tick += (sender, args) =>
            {
                timerend.Stop();
                EventoTipo.Content = "Nessun evento da mostrare";
                EventoDurata.Content = "";
            };
        }

        private void ApriPannelloRapido(object sender, RoutedEventArgs e)
        {
            PannelloRapido panel = new PannelloRapido();
            panel.Show();
        }






    }
}
