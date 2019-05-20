using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    [Serializable]
    public class Issue
    {
        public Category Category
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public int Edition
        {
            get; set;
        }
        public bool Periodicity
        {
            get; set;
        }

        public Issue() {}

        public Issue (Category category, string name, int edition, bool periodicity)
        {
            Category = category;
            Name = name;
            Edition = edition;
            Periodicity = periodicity;
        }

        public void OutPutInfo(Issue issue)
        {
            Console.WriteLine("Целевая аудитория: {0}; название: {1}; тираж: {2}; " +
                "периодическое: {3}", issue.Category.TargetAudience, issue.Name, issue.Edition,
                issue.Periodicity);
        }
    }
}
