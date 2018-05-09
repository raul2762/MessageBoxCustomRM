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
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace MessageBoxCustomRM
{
    /// <summary>
    /// Lógica de interacción para MessageWindows.xaml
    /// </summary>
    public partial class MessageWindows : MetroWindow
    {
        public string Contenido { get; set; }
        public MessageBoxResult ResultRetornado { get; set; }
        public MessageWindows()
        {
            InitializeComponent();
        }

        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        public void Redimensionar()
        {
            double alto = lblContent.RenderSize.Height;
            if (alto > 82)
            {
                this.Height = alto + 115;
                CenterWindowOnScreen();
            }
            else
            {
                this.Height = 206;
                CenterWindowOnScreen();
            }
            
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lblContent.Text = Contenido;
            //ImgShow.Source = (ImageSource)FindResource("Question");
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            ResultRetornado = MessageBoxResult.OK;
            this.Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ResultRetornado = MessageBoxResult.Cancel;
            this.Close();
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
                Redimensionar();
        }
    }


}
