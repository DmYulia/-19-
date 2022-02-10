using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace nineteen
{
    class Program
    {
        static void Print(List<Modelpc> pc)
        {
            foreach (Modelpc e in pc)
            {
                WriteLine($"{e.Code} {e.MarkName} {e.TypeCPU} {e.RateCPU} {e.SizeRAM} {e.SizeHDD} {e.SizeGPU} {e.Prise} {e.StokBalanse}");
            }
            WriteLine();
        }
        static void Main(string[] args)
        {
            List<Modelpc> PC = new List<Modelpc>()
            {
                new Modelpc(){Code=1, MarkName="Lenovo", TypeCPU="Intel", RateCPU=2.4, SizeRAM=4, SizeHDD=512, SizeGPU=2, Prise=57, StokBalanse=7},
                new Modelpc(){Code=2, MarkName="DNS", TypeCPU="AMD", RateCPU=1.8, SizeRAM=4, SizeHDD=256, SizeGPU=1, Prise=32, StokBalanse=3},
                new Modelpc(){Code=3, MarkName="HP", TypeCPU="Intel", RateCPU=3.2, SizeRAM=8, SizeHDD=512, SizeGPU=1, Prise=46, StokBalanse=5},
                new Modelpc(){Code=4, MarkName="Aser", TypeCPU="AMD", RateCPU=2.4, SizeRAM=8, SizeHDD=1024, SizeGPU=2, Prise=63, StokBalanse=24},
                new Modelpc(){Code=5, MarkName="Asus", TypeCPU="Intel", RateCPU=2.2, SizeRAM=16, SizeHDD=512, SizeGPU=2, Prise=120, StokBalanse=33},
                new Modelpc(){Code=6, MarkName="Apple", TypeCPU="CAP", RateCPU=3.0, SizeRAM=32, SizeHDD=1024, SizeGPU=4, Prise=180, StokBalanse=17},
                new Modelpc(){Code=7, MarkName="DELL", TypeCPU="Intel", RateCPU=3.4, SizeRAM=4, SizeHDD=256, SizeGPU=2, Prise=49, StokBalanse=2},
                new Modelpc(){Code=8, MarkName="IRBIS", TypeCPU="AMD", RateCPU=1.6, SizeRAM=2, SizeHDD=256, SizeGPU=1, Prise=27, StokBalanse=1}
            };
////
            WriteLine("Введите процессор");
            string typecpu = ReadLine();
            List<Modelpc> pc1 = PC.Where(x => x.TypeCPU == typecpu).ToList();
            Print(pc1);
////
            WriteLine("Введите объем ОЗУ");
            int ram = Convert.ToInt32(ReadLine());
            List<Modelpc> pc2 = PC.Where(x => x.SizeRAM >= ram).ToList();
            Print(pc2);
////
            List<Modelpc> pc3 = PC.OrderBy(x => x.Prise).ToList();
            Print(pc3);
////
            IEnumerable<IGrouping<string, Modelpc>> pc4 = PC.GroupBy(x => x.TypeCPU);
            foreach (IGrouping<string, Modelpc> a in pc4)
            {
                 WriteLine(a.Key);
                foreach (Modelpc e in a)
                {
                    WriteLine($"{e.Code} {e.MarkName} {e.TypeCPU} {e.RateCPU} {e.SizeRAM} {e.SizeHDD} {e.SizeGPU} {e.Prise} {e.StokBalanse}");
                }
            }
            WriteLine();
////
            Modelpc pc5 = PC.OrderByDescending(x => x.Prise).FirstOrDefault();
            WriteLine($"{pc5.Code} {pc5.MarkName} {pc5.TypeCPU} {pc5.RateCPU} {pc5.SizeRAM} {pc5.SizeHDD} {pc5.SizeGPU} {pc5.Prise} {pc5.StokBalanse}");
            WriteLine();
////
            Modelpc pc6 = PC.OrderByDescending(x => x.Prise).LastOrDefault();
            WriteLine($"{pc6.Code} {pc6.MarkName} {pc6.TypeCPU} {pc6.RateCPU} {pc6.SizeRAM} {pc6.SizeHDD} {pc6.SizeGPU} {pc6.Prise} {pc6.StokBalanse}");
            WriteLine();
////
            WriteLine(PC.Any(x => x.StokBalanse >= 30));

            ReadKey();

        }
    }
}