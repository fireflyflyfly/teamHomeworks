using System;
namespace TeamHomeworks.Task_6
{
    public class ColouredChaplet : Chaplet<ColouredBulb>
    {
        public ColouredChaplet() : base()
        {
            Console.WriteLine("\nPlease enter the number of light bulbs in your chaptet:");
            int attempts = 3;
            while (attempts != 0)
            {
                if (int.TryParse(Console.ReadLine(), out int length))
                {
                    for (int i = 0; i < length; i++)
                    {
                        ColouredBulb colouredBulb = BulbHelper.SetBulbColour();
                        cplt.Add(colouredBulb);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please use only integers.");
                    attempts--;
                }

                if (attempts == 0)
                {
                    Console.WriteLine("You are out of attempts, the length of your chaplet has been defaulted to 10.");
                    for (int i = 0; i < 10; i++)
                    {
                        ColouredBulb colouredBulb = BulbHelper.SetBulbColour();
                        cplt.Add(colouredBulb);
                    }
                }
            }
        }

        public override void PrintChaplet()
        {
            foreach (ColouredBulb bulb in cplt)
            {
                SetBulbState();
                Console.WriteLine($"\n{cplt.IndexOf(bulb)}, Color: {Enum.GetName(typeof(Colour), bulb.BulbColour)}, Is lit: {bulb.IsLit}");
            }
        }
    }
}
