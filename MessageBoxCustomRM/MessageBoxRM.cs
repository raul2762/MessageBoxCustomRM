using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace MessageBoxCustomRM
{
   public enum MessageBoxButtonRM
    {
        OK,
        OKCancel,
        YesNo
    }
    public enum MessageBoxIconRM
    {
        Information,
        Question,
        Warning,
        Error
    }
    public static class MessageBoxRM
    {
        //
        // Resumen:
        //     Muestra un cuadro de mensaje con el texto especificado.
        //
        // Parámetros:
        //   text:
        //     Texto que se va a mostrar en el cuadro de mensaje.
        //
        // Devuelve:
        //     Uno de los valores de System.Windows.MessageBoxResult.
        public static MessageBoxResult Show(String text)
        {
            MessageBoxResult result = MessageBoxResult.No;
            MessageWindows abrir = new MessageWindows();
            abrir.btn1.Visibility = Visibility.Hidden;
            abrir.btn2.Content = "Aceptar";
            abrir.Contenido = text;
            abrir.Title = "";
            abrir.ShowDialog();
            result = abrir.ResultRetornado;
            return result;
        }

        public static MessageBoxResult Show(String text, String title)
        {
            MessageBoxResult result = MessageBoxResult.No;
            MessageWindows abrir = new MessageWindows();
            abrir.btn1.Visibility = Visibility.Hidden;
            abrir.btn2.Content = "Aceptar";
            abrir.Title = title;
            abrir.Contenido = text;
            abrir.ShowDialog();
            result = abrir.ResultRetornado;
            return result;
        }

        public static MessageBoxResult Show(String text, String title, MessageBoxButtonRM buttons)
        {
            MessageBoxResult result = MessageBoxResult.No;
            MessageWindows abrir = new MessageWindows();
            switch (buttons)
            {
                case MessageBoxButtonRM.OK:
                    abrir.btn1.Visibility = Visibility.Hidden;
                    abrir.btn2.Content = "Aceptar";
                    break;
                case MessageBoxButtonRM.OKCancel:
                    abrir.btn1.Content = "Aceptar";
                    abrir.btn2.Content = "Cancelar";
                    break;
                case MessageBoxButtonRM.YesNo:
                    abrir.btn1.Content = "Si";
                    abrir.btn2.Content = "No";
                    break;
                default:
                    abrir.btn1.Visibility = Visibility.Hidden;
                    abrir.btn2.Content = "Aceptar";
                    break;
            }
            abrir.Title = title;
            abrir.Contenido = text;
            abrir.ShowDialog();
            result = abrir.ResultRetornado;
            return result;
        }

        public static MessageBoxResult Show(String text, String title, MessageBoxButtonRM buttons,MessageBoxIconRM icon)
        {
            MessageBoxResult result = MessageBoxResult.No;
            MessageWindows abrir = new MessageWindows();
            switch (buttons)
            {
                case MessageBoxButtonRM.OK:
                    abrir.btn1.Visibility = Visibility.Hidden;
                    abrir.btn2.Content = "Aceptar";
                    break;
                case MessageBoxButtonRM.OKCancel:
                    abrir.btn1.Content = "Aceptar";
                    abrir.btn2.Content = "Cancelar";
                    break;
                case MessageBoxButtonRM.YesNo:
                    abrir.btn1.Content = "Si";
                    abrir.btn2.Content = "No";
                    break;
                default:
                    abrir.btn1.Visibility = Visibility.Hidden;
                    abrir.btn2.Content = "Aceptar";
                    break;
            }

            switch (icon)
            {
                case MessageBoxIconRM.Information:
                    abrir.ImgShow.Source = new BitmapImage(new Uri("pack://application:,,,/MessageBoxCustomRM;component/information.png"));
                    break;
                case MessageBoxIconRM.Question:
                    abrir.ImgShow.Source = new BitmapImage(new Uri("pack://application:,,,/MessageBoxCustomRM;component/help-circle.png"));
                    break;
                case MessageBoxIconRM.Warning:
                    abrir.ImgShow.Source = new BitmapImage(new Uri("pack://application:,,,/MessageBoxCustomRM;component/alert.png"));
                    break;
                case MessageBoxIconRM.Error:
                    abrir.ImgShow.Source = new BitmapImage(new Uri("pack://application:,,,/MessageBoxCustomRM;component/icon-error.png"));
                    break;
                default:
                    abrir.ImgShow.Source = new BitmapImage(new Uri("pack://application:,,,/MessageBoxCustomRM;component/information.png"));
                    break;
            }
            abrir.Title = title;
            abrir.Contenido = text;
            abrir.ShowDialog();
            result = abrir.ResultRetornado;
            return result;
        }
    }
}
