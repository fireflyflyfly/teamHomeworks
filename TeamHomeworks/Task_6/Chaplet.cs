using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamHomeworks.Task_6
{
    public abstract class Chaplet<T>
        where T : SimpleBulb
    {
        protected T[] cplt;

        public Chaplet(int size) => FillChaplet(size);

        public abstract void FillChaplet(int length);
        public abstract void PrintChaplet();

        protected void SetBulbState()
        {
            var currentMinute = DateTime.Now.Minute;
            for (int i = 0; i < cplt.Length; i++)
            {
                if (i % 2 == currentMinute % 2)
                {
                    cplt[i].IsLit = true;

                }
            }
        }
    }
}
