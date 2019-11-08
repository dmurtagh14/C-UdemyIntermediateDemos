using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Text : PresentationObject
    {
        public int Fontsize { get; set; }
        public int FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }

    }
}
