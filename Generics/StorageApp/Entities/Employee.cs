﻿namespace StorageApp.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, Firstname: {FirstName}";
    }
}