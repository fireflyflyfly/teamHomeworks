using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamHomeworks.Task_6
{
    public abstract class Chaplet<T> where T : SimpleBulb
    {
        protected List<T> cplt;
        public Chaplet()
        {
            cplt = new List<T>();
        }

        public void Add(SimpleBulb bulb)
        {
            bulb.IsLit = false;
        }

        protected void SetBulbState()
        {
            var currentMinute = DateTime.Now.Minute;
            for (int i = 0; i < cplt.Count; i++)
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

        public abstract void PrintChaplet();


        //public SimpleBulb[] chaplet;
        //chaplet creation logic should be in constructor, generic should also be here.
        //public Chaplet(SimpleBulb bulb)
        //{
        //}
    }
}
