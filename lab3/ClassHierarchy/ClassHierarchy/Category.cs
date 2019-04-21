using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    [Serializable]
    public class Category
    {
        public string NatureOfInfo
        {
            get; set;
        }
        public string TargetAudience
        {
            get; set;
        }
        public bool Originality
        {
            get; set;
        }

        public Category() {}

        public Category(string natureOfInfo, string targetAudience, bool originality)
        {
            NatureOfInfo = natureOfInfo;
            TargetAudience = targetAudience;
            Originality = originality;
        }
    }
}
