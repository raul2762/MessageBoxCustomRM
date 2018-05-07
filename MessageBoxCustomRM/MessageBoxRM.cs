using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MessageBoxCustomRM
{
   public enum MessageBoxButtonRM
    {
        OK,
        OKCancel,
        YesNo
    }
    public static class MessageBoxRM
    {
       
        public static MessageBoxResult Show(String text)
        {
            MessageBoxResult result = MessageBoxResult.No;
            MessageWindows abrir = new MessageWindows();
            abrir.btn1.Visibility = Visibility.Hidden;
            abrir.btn2.Content = "Aceptar";
            abrir.Contenido = text;
            abrir.Show();

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
            abrir.Show();

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
                    break;
            }
            abrir.Title = title;
            abrir.Contenido = text;
            abrir.Show();

            return result;
        }
    }
}
