using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nineteen
{
    internal class Modelpc
    {
        public int Code { get; set; }
        public string MarkName { get; set; }
        public string TypeCPU { get; set; }
        public double RateCPU { get; set; }
        public int SizeRAM { get; set; }
        public double SizeHDD { get; set; }
        public double SizeGPU { get; set; }
        public double Prise { get; set; }
        public int StokBalanse { get; set; }
    }
}
