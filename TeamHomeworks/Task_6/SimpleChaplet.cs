using System;
namespace TeamHomeworks.Task_6
{
    public class SimpleChaplet : Chaplet<SimpleBulb>
    {
        public SimpleChaplet(int size) : base(size)
        {
        }

        public override void FillChaplet()
        {

            for (int i = 0; i < cplt.Length; i++)
            {
                SimpleBulb simpleBulb = new SimpleBulb();
                cplt[i] = simpleBulb;
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