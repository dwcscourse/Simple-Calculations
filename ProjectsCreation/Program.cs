﻿using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int manHours = numberOfProjects * 3;
            Console.WriteLine($"The architect {name} will need {manHours} hours to complete {numberOfProjects} project/s.");
        }
    }
}
