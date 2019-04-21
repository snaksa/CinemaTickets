using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTickets.Models
{
    class GenreOption
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public GenreOption(int id, string text)
        {
            this.Id = id;
            this.Text = text;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
