using System;
using System.Collections.Generic;

namespace _04_Hospital
{
    class Doctor
    {
        public string Name { get; }
        private List<string> patients;

        public void AddPatient(string patient)
        {
            patients.Add(patient);
        }

        public void PrintPatients()
        {
            patients.Sort();
            foreach (var patient in patients)
                Console.WriteLine(patient);
        }

        public Doctor(string name, string patient)
        {
            Name = name;
            patients = new List<string>();
            patients.Add(patient);
        }
    }
}
