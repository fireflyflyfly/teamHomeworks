using System;
namespace TeamHomeworks.Task_6
{
    public class SimpleChaplet : Chaplet<SimpleBulb>
    {
        public SimpleChaplet(int size) : base(size)
        {
        }

        public override void FillChaplet(int length)
        {
            cplt = new SimpleBulb[length];
            for (int i = 0; i < length; i++)
            {

                cplt[i] = new SimpleBulb(); 
            }
        }


        public override void PrintChaplet()
        {
            int index = 0;
            foreach (SimpleBulb bulb in cplt)
            {
                SetBulbState();
                Console.WriteLine($"\n{index}, Is lit: {bulb.IsLit}");
                index++;
            }
        }
    }
}