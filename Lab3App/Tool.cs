using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        public Tool(string Description) : base(Description) { }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }

        public virtual void DoAction() { }
    }
}
