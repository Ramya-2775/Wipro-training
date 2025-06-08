﻿namespace WebApplication19.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Rating  { get; set; }
        public string Message { get; set; }
        public DateTime submittedon { get; set; } = DateTime.Now;

    }
}
