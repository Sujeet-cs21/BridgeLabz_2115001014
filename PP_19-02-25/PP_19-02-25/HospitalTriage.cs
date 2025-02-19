using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class Patient : IComparable<Patient>
    {
        public string Name { get; set; }
        public int Severity { get; set; }

        public Patient(string name, int severity)
        {
            Name = name;
            Severity = severity;
        }

        public int CompareTo(Patient other)
        {
            return other.Severity.CompareTo(this.Severity);
        }
    }

    class HospitalTriage
    {
        public static void Main13()
        {
            SortedSet<Patient> priorityQueue = new SortedSet<Patient>();

            // Add patients with severity
            priorityQueue.Add(new Patient("John", 3));
            priorityQueue.Add(new Patient("Alice", 5));
            priorityQueue.Add(new Patient("Bob", 2));

            Console.WriteLine("Treatment Order:");
            while (priorityQueue.Count > 0)
            {
                Patient patient = priorityQueue.Min;
                Console.WriteLine(patient.Name);
                priorityQueue.Remove(patient);
            }
        }
    }

}
