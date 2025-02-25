
using System.Collections.Generic;
using System.Threading;

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

            List<string> outputLog = new List<string>();

            while (true)
            {
                string output = data.ToString();
                outputLog.Add(output);
                if (outputLog.Count > 10) outputLog.RemoveAt(0); // Keep last 10 logs

                outputBox.Dispatcher.Invoke(() => outputBox.Text = string.Join("\n", outputLog));
                Thread.Sleep(100);
            }
        }
    }
}