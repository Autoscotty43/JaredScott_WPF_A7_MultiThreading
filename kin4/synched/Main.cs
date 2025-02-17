using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Xml.Linq;

namespace kin4.synched
{
    public class Main
    {
        public void Main1(System.Windows.Controls.TextBox outputBox)
        {
            Data data = new Data();
            Thread[] threads = new Thread[300];

            for (int i = 0; i < 100; i++)
            {
                threads[i] = new Thread(new CharacterThread(data, "Tin Man", Colors.Silver).Run);
                threads[i + 100] = new Thread(new CharacterThread(data, "Scarecrow", Colors.Brown).Run);
                threads[i + 200] = new Thread(new CharacterThread(data, "Cowardly Lion", Colors.Yellow).Run);
            }

            foreach (var thread in threads)
                thread.Start();

            while (true)
            {
                outputBox.Dispatcher.Invoke(() => outputBox.Text = data.ToString());
                Thread.Sleep(100);
            }
        }
    }
}