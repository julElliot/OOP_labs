using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    [Serializable]
    public class Mini_Issue: Issue
    {
        public string Kind
        {
            get; set;
        }

        public Mini_Issue() {}

        public Mini_Issue(Category category, string name, int edition, bool periodicity, string kind)
            : base(category, name, edition, periodicity)
        {
            Kind = kind;
        }
    }
}
