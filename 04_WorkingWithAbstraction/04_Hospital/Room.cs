using System;

namespace _04_Hospital
{
    class Room
    {
        private const int roomSize = 3;

        private string[] patients = new string[roomSize];
        private int idx = 0;

        public bool IsFull { get => idx == roomSize; }

        public void Sort()
        {
            for (int i = 0; i < idx; i++)
                for (int j = i + 1; j < idx; j++)
                    if (patients[i].CompareTo(patients[j]) > 0)
                    {
                        var tmp = patients[i];
                        patients[i] = patients[j];
                        patients[j] = tmp;
                    }
        }

        public void Print()
        {
            for (int i = 0; i < idx; i++)
                Console.WriteLine(patients[i]);
        }

        public void AddPatient(string patient)
        {
            patients[idx++] = patient;
        }

        public Room(string patient)
        {
            AddPatient(patient);
        }
    }
}
