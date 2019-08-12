using System;
namespace TeamHomeworks.Task_6
{
    public class ChapletRunner
    {
        public static void StartChaplet()
        {
            var simpleChap = new SimpleChaplet();
            simpleChap.PrintChaplet();

            var colouerdChap = new ColouredChaplet();
            colouerdChap.PrintChaplet();
        }
    }
}
