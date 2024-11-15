﻿namespace DataDemo.Models
{
    public class Campus
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            return Name??"";
        }
    }
}
