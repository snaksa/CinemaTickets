using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTickets.Models
{
   public class SelectedSeats
    {
        public SelectedSeats(int standard, int elder, int student)
        {
            this.Standard = standard;
            this.Elder = elder;
            this.Student = student;
        }

        public int Standard { get; set; }
        public int Elder { get; set; }
        public int Student { get; set; }

        public int Sum()
        {
            return this.Standard + this.Elder + this.Student;
        }
    }
}
