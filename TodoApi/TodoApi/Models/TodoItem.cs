﻿namespace TodoApi.Models
{
    // A model is a set of classes that represent the data that the app manages.
    // The model for this app is a single TodoItem class.
    public class TodoItem
    {
        // The Id property functions as the unique key in a relational database.
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
