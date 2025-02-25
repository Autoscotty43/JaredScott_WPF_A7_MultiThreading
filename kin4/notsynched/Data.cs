using System;
using System.Threading;

namespace kin4.notsynched
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

            // Detect mismatch
            if ((FavoriteCharacter != character && FavoriteColor == color) ||
                (FavoriteCharacter == character && FavoriteColor != color))
            {
                Console.WriteLine($"MISMATCH! Dorthy's favorite: {character}, Color: {color}");
            }

            Thread.Sleep(new Random().Next(100, 300));
            FavoriteCharacter = character;
            Thread.Sleep(new Random().Next(100, 300));
            FavoriteColor = color;
        }

        public override string ToString()
        {
            return $"Dorthy's favorite: {FavoriteCharacter}, Color: {FavoriteColor}";
        }
    }
}