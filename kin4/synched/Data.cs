using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Policy;

namespace kin4.synched
{
    public class Data
    {
        public string FavoriteCharacter { get; set; }
        public Colors FavoriteColor { get; set; }

        public Data()
        {
            FavoriteCharacter = "Dorthy";
            FavoriteColor = Colors.Yellow;
        }

        public void SetFavorite(string character, Colors color)
        {
            FavoriteCharacter = character;
            FavoriteColor = color;
        }

        public override string ToString()
        {
            return $"Dorthy's favorite: {FavoriteCharacter}, Color: {FavoriteColor}";
        }
    }
}