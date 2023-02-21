using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> schools = new Dictionary<int, string>();

        schools.Add(1, "Tallinna Juudikool");
        schools.Add(2, "Kuusalu Keskkool");
        schools.Add(3, "TTHK");
        schools.Add(4, "EBS");
        schools.Add(5, "Tallina täiskasvanute gümnaasium");

        foreach (KeyValuePair<int, string> school in schools)
        {
            Console.WriteLine("Kooli number {0} nimi on {1}.", school.Key, school.Value);
        }
    }
}