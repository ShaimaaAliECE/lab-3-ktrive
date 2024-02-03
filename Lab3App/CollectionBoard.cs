using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class CollectionBoard
    {
        private int totalValue;
        private int totalScore;

        public int TotalValue
        {
            get { return totalValue; }
            set { totalValue = value; }
        }

        public int TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }
    }
}
