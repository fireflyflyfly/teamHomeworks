using System;
namespace TeamHomeworks.Task_6
{
    public class ChapletRunner
    {
        public static void StartChaplet()
        {
            var simpleChap = new SimpleChaplet(ChapletHelper.GetChapletLength());
            simpleChap.FillChaplet();
            simpleChap.PrintChaplet();

            var colouerdChap = new ColouredChaplet(ChapletHelper.GetChapletLength());
            colouerdChap.FillChaplet();
            colouerdChap.PrintChaplet();
        }
    }
}
