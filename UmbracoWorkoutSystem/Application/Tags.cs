using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem.Application
{
    class Tags
    {
        public List<string> Taglist { get; }

        public Tags()
        {
            Taglist.Add("Ryg");
            Taglist.Add("Lænd");
            Taglist.Add("Balder");
            Taglist.Add("Ben");
            Taglist.Add("Mave");
            Taglist.Add("Arme");
            Taglist.Add("Overkrop");
        }

    }
}
