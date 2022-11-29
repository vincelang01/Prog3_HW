using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VG0DQ7.Model
{
    public class WorkStorage
    {
        List<Work> WorkList;

        public WorkStorage()
        {
            WorkList = new List<Work>();
        }

        public int Count()
        {
            return WorkList.Count;
        }

        public Work this[int index] { get { return WorkList[index]; } }

        public void AddWorks(List<Work> workToAdd)
        {
            WorkList.AddRange(workToAdd);
        }

        public void DeleteList()
        {
            WorkList.Clear();
        }
    }
}
