using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxCustomRM
{
    public static class MessageBoxRM
    {
        public static void Show()
        {
            MessageWindows abrir = new MessageWindows();
            abrir.Show();
        }
    }
}
