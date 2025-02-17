using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace kin4.synched
{
    public class CharacterThread
    {
        private Data _data;
        private string _character;
        private Colors _color;

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
                _data.SetFavorite(_character, _color);
            }
        }
    }
}