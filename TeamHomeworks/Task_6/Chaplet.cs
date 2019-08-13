using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamHomeworks.Task_6
{
    public abstract class Chaplet<T>
        where T : SimpleBulb
    {
        protected T[] cplt;

        public Chaplet(int size)
        {
            cplt = new T[size];
        }

        public abstract void FillChaplet();
        public abstract void PrintChaplet();

        protected void SetBulbState()
        {
            var currentMinute = DateTime.Now.Minute;
            for (int i = 0; i < cplt.Length; i++)
            {
                if (i % 2 == 0 && currentMinute % 2 == 0)
                {
                    cplt[i].IsLit = true;
                }
                else if (i % 2 != 0 && currentMinute % 2 != 0)
                {
                    cplt[i].IsLit = true;
                }
            }
        }
    }
}
