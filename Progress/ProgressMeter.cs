using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress
{
    public abstract class ProgressMeter
    {
        protected readonly int max;
        private int position;

        public int Position 
        {
            get
            {
                return position;
            }
            set 
            {
                position = value;
                Draw();
            } 
        }

        protected ProgressMeter (int max) 
        { 
            this.max = max;
        }
        // Этот м-д ничего не делает
        public abstract void Draw();
    }



    


}
