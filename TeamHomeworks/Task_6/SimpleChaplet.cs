using System;
namespace TeamHomeworks.Task_6
{
    public class SimpleChaplet : Chaplet<SimpleBulb>
    {
        public SimpleChaplet() : base()
        {
            Console.WriteLine("\nPlease enter the number of light bulbs in your chaptet:");
            int attempts = 3;
            while (attempts != 0)
            {
                if (int.TryParse(Console.ReadLine(), out int length))
                {
                    for (int i = 0; i < length; i++)
                    {
                        SimpleBulb simpleBulb = new SimpleBulb();
                        cplt.Add(simpleBulb);
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
                        SimpleBulb simpleBulb = new SimpleBulb();
                        cplt.Add(simpleBulb);
                    }
                }
            }
        }

        public override void PrintChaplet()
        {
            foreach (SimpleBulb bulb in cplt)
            {
                SetBulbState();
                Console.WriteLine($"\n{cplt.IndexOf(bulb)}, Is lit: {bulb.IsLit}");
            }
        }
    }
}