using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M426_Projekt_Core.Models.Share;

namespace M426_Projekt_Core.Models.List
{
    public class ListViewModel
    {
        // Um die Liste zu identifizieren
        public int ID { get; set; }
        // Listen-Name
        public string Name { get; set; }
        // Share
        public ShareModel Share { get; set; }
    }
}
