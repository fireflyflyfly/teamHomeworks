using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamHomeworks.Task_6
{
    public class ColouredChaplet : Chaplet<ColouredBulb>
    {
        public static List<Colour> colourList = Enum.GetValues(typeof(Colour)).Cast<Colour>().ToList();

        public ColouredChaplet(int size) : base(size)
        {
        }

        public override void FillChaplet()
        {
            for (int i = 0; i < cplt.Length; i++)
            {
                ColouredBulb colouredBulb = new ColouredBulb();
                cplt[i] = colouredBulb;
            }

            SetBulbColour();
        }

        public override void PrintChaplet()
        {
            int index = 0;
            foreach (ColouredBulb bulb in cplt)
            {
                SetBulbState();
                Console.WriteLine($"\n{index}, Color: {Enum.GetName(typeof(Colour), bulb.BulbColour)}, Is lit: {bulb.IsLit}");
                index++;
            }
        }

        public void SetBulbColour()
        {
            int index1 = 0;
            int index2 = 0;
            while (index2 != cplt.Length)
            {
                if (index1 != colourList.Count)
                {
                    cplt[index2].BulbColour = colourList[index1];
                    index1++;
                    index2++;
                }
                else
                {
                    index1 = 0;
                }
            }
        }
    }
}
