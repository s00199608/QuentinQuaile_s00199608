using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuentinQuaile_s00199608
{
    public class Game
    {
        [Key]
        public string Name { get; set; }
        public string Platform { get; set; }
        public int CriticScore { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }
        public string Description { get; set; }

        public Game()
        {
            Name = "abc";
            Platform = "AC/DC";
            CriticScore = 10;
            Price = 100.99m;
            GameImage = "Not Given";
            Description = "Put the ABC's in the bag and nobody gets hurt";
        }

        public Game(string name, string platform, int score, decimal price, string gameimage, string description)
        {
            Name = name;
            Platform = platform;
            CriticScore = score;
            Price = price;
            GameImage = gameimage;
            Description = description;
        }

        public void DecreasePrice(decimal total)
        {
            Price -= total;
        }

    }

    public class GameData : DbContext
    {
        public GameData() : base("MyGameData")
        {

        }
        public DbSet<Game> Games { get; set; }
    }
}
