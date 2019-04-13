﻿namespace CinemaTickets.Models
{
    class MovieType
    {
        public MovieType(int id = 0, string name = "", int price = 0)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
