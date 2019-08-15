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

        public override void FillChaplet(int length)
        {
            cplt = new ColouredBulb[length];
            for (int i = 0; i < length; i++)
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
            int colourIndex = 0;
            int chapletIndex = 0;
            while (chapletIndex != cplt.Length)
            {
                if (colourIndex != colourList.Count)
                {
                    cplt[chapletIndex].BulbColour = colourList[colourIndex];
                    colourIndex++;
                    chapletIndex++;
                }
                else
                {
                    colourIndex = 0;
                }
            }
        }
    }
}
