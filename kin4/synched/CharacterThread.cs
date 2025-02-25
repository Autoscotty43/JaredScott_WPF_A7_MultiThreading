
using System.Threading;

namespace kin4.synched
{
    public class CharacterThread
    {
        private Data _data;
        private string _character;
        private Colors _color;
        private object _lock = new object();

        public CharacterThread(Data data, string character, Colors color)
        {
            _data = data;
            _character = character;
            _color = color;
        }

        public void Run()
        {
            while (true)
            {
                lock (_lock)  // Synchronization remains
                {
                    _data.SetFavorite(_character, _color);
                    Thread.Sleep(1500);  // Introduce sleep
                }
            }
        }
    }
}