using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VG0DQ7.Model
{
    public class Services
    {
        List<Work> ServiceOrder;

        public int TotalWorkTimeCost
        {
            get
            {
                var minutes = (from items in ServiceOrder select items.Minutes + items.Hours * 60).Sum();
                //Every half hour matters
                int totalHalfHour = (minutes % 30 == 0 ? minutes / 30 : minutes / 30 + 1);
                return totalHalfHour * 7500;
            }
        }

        public Work this[int index]
        {
            get { return ServiceOrder[index]; }
        }

        public int TotalTimeOfWork { get { return (from items in ServiceOrder select items.time).Sum(); } }

        public int TotalMaterialCost
        {
            get { return (from items in ServiceOrder select items.MaterialCost).Sum(); }
        }

        public int TotalNumberOfWorks { get { return ServiceOrder.Count; } }

        public Services()
        {
            ServiceOrder = new List<Work>();
        }

        public void AddItem(Work work)
        {
            ServiceOrder.Add(work);
            ServiceOrder = ServiceOrder.Distinct().ToList();
        }

        public void RemoveItem(Work work)
        {
            ServiceOrder.Remove(work);
            ServiceOrder = ServiceOrder.Distinct().ToList();
        }
    }
}
