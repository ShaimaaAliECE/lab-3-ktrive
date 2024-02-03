using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure
    {
        private int Value;

        public Coin(string Description, int score, int value) : base(Description, score) 
        {
            this.Value = value;
        }

        public void UpdateTotalValue() 
        {
            Board.TotalValue += this.Value;
            Console.WriteLine("Total value is updated to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + this.Description + " is displayed.");
        }
    }
}
