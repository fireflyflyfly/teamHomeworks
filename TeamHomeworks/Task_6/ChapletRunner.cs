using System;
using System.Collections.Generic;

namespace TeamHomeworks.Task_6
{
    public class ChapletRunner
    {
        public static void StartChaplet()
        {
            var simpleChap = new SimpleChaplet(ChapletHelper.GetChapletLength());
            simpleChap.PrintChaplet();

            var colouerdChap = new ColouredChaplet(ChapletHelper.GetChapletLength());
            colouerdChap.PrintChaplet();
        }
    }
}
