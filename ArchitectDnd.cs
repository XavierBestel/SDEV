using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnd_Archtype_Item
{
    internal class ArchitectDnd
    {
        public string Name { get; set; }
        public List<string> ArchChildren { get; set; }

        public ArchitectDnd()
        {

            ArchChildren = new List<string>();
        }
    }
}
