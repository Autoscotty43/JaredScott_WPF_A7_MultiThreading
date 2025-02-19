using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace kin4.notsynched
{
    public class CharacterThread
    {
        private readonly Data _data;
        private readonly string _character;
        private readonly Colors _color;
        private static readonly object _lock = new object();

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
                lock (_lock)
                {
                    _data.SetFavorite(_character, _color);
                }
            }
        }
    }
}