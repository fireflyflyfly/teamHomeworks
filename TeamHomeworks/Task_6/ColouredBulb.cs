using System;
namespace TeamHomeworks.Task_6
{
    public class ColouredBulb : SimpleBulb
    {
        public Colour BulbColour { get; set; }
        public ColouredBulb(Colour colour)
        {
            BulbColour = colour;
        }
    }
}
