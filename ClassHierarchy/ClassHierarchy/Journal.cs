using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    class Journal: Issue
    {
        public int SerialNumber
        {
            get; set;
        }
        public string Topic
        {
            get; set;
        }
        public string Redactors
        {
            get; set;
        }

        public Journal(Category category, string name, int edition, bool periodicity, int serialNumber, string topic, string redactors)
            : base(category, name, edition, periodicity)
        {
            SerialNumber = serialNumber;
            Topic = topic;
            Redactors = redactors;
        }
    }
}
