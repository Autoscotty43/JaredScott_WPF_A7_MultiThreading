
using System.Threading;

namespace kin4.notsynched
{
    public class CharacterThread
    {
        private readonly Data _data;
        private readonly string _character;
        private readonly Colors _color;

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
                _data.SetFavorite(_character, _color);  // No lock here (non-synchronized)
                Thread.Sleep(500);  // Introduce sleep
            }
        }
    }
}