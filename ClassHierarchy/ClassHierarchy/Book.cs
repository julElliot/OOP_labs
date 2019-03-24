using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    class Book: Issue
    {
        public string Author
        {
            get; set;
        }
        public string Binding
        {
            get; set;
        }
        public bool IllustratedBookend
        {
            get; set;
        }

        public Book(Category category, string name, int edition, bool periodicity, string author, string binding, bool illustratedBookend)
            : base(category, name, edition, periodicity)
        {
            Author = author;
            Binding = binding;
            IllustratedBookend = illustratedBookend;
        }
    }
}
