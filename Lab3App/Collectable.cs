using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        protected string Description;
        public CollectionBoard Board;

        public Collectable(string Description)
        {
            this.Description = Description;
        }

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(this.Description + " collected, congrats!!!!");
        }

        public abstract void Display();
    }
}
