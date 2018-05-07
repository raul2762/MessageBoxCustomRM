using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxCustomRM
{
    public static class MessageBoxRM
    {
        public static void Show(String Titulo)
        {
            MessageWindows abrir = new MessageWindows();
            abrir.Title = Titulo;
            abrir.Show();
        }
    }
}
