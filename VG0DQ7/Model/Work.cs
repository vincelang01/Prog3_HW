using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VG0DQ7.Model
{
    public class Work
    {
        public string Name { get; private set; }
        public int time { get; private set; }
        public int Minutes { get { return time % 60; } }
        public int Hours { get { return time / 60; } }

        public int MaterialCost { get; private set; }
        public string TimeOfWork { get { return $"{(Hours > 0 ? Hours + "ó " : "")}" + $"{(Minutes >= 0 ? Minutes + "p" : "")}"; } }
        public int CostOfTime { get { return (Hours * 15000) + (Minutes * 15000 / 60); } }

        public Work(string Name, int time, int MaterialCost)
        {
            this.Name = Name;
            this.time = time;
            this.MaterialCost = MaterialCost;
        }
    }
}
