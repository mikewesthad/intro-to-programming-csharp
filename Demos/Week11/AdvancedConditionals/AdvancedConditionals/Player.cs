using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week11_Conditionals
{
    class Player
    {
        public string Name;
        public bool HasBeatenGame;
        public int Score;
        public bool HasShield;
        public int Defense;
        public int Attack;
        public bool IsPacifist;

        public Player()
        {
            Name = "No name";
            HasBeatenGame = false;
            Score = 0;
            HasShield = false;
            Defense = 0;
            Attack = 0;
            IsPacifist = false;
        }

        public void PrintPlayerStats()
        {
            Console.WriteLine($"== Player {Name}'s Stats ==");
            Console.WriteLine($"HasBeatenGame: {HasBeatenGame}");
            Console.WriteLine($"Score:         {Score}");
            Console.WriteLine($"HasShield:     {HasShield}");
            Console.WriteLine($"Defense:       {Defense}");
            Console.WriteLine($"Attack:        {Attack}");
            Console.WriteLine($"IsPacifist:    {IsPacifist}");
        }

        public void LoadSaveData(string path)
        {
            string[] lines = File.ReadAllLines(path);
            Name = ParseDataLineToString(lines[0]);
            HasBeatenGame = ParseDataLineToBoolean(lines[1]);
            Score = ParseDataLineToInt(lines[2]);
            HasShield = ParseDataLineToBoolean(lines[3]);
            Defense = ParseDataLineToInt(lines[4]);
            Attack = ParseDataLineToInt(lines[5]);
            IsPacifist = ParseDataLineToBoolean(lines[6]);
        }

        private string ParseDataLineToString(string line)
        {
            string[] parts = line.Split(':');
            string value = parts[1].Trim();
            return value;
        }

        private bool ParseDataLineToBoolean(string line)
        {
            string booleanValue = ParseDataLineToString(line);
            return Convert.ToBoolean(booleanValue);
        }

        private int ParseDataLineToInt(string line)
        {
            string intValue = ParseDataLineToString(line);
            return Convert.ToInt32(intValue);
        }
    }
}
