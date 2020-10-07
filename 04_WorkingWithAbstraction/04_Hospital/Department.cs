using System.Collections.Generic;

namespace _04_Hospital
{
    class Department
    {
        private const int capacity = 20;

        public string Name { get; }
        private List<Room> rooms = new List<Room>();

        public bool IsFull { get => rooms.Count == 20; }

        public void UpdateInfo(string patientName)
        {
            if (!rooms[rooms.Count - 1].IsFull)
                rooms[rooms.Count - 1].AddPatient(patientName);
            else if (rooms.Count != capacity)
                rooms.Add(new Room(patientName));
        }

        public void Print()
        {
            foreach (var room in rooms)
                room.Print();
        }

        public void Print(int roomIdx)
        {
            rooms[roomIdx].Sort();
            rooms[roomIdx].Print();
        }

        public Department(string name, string patient)
        {
            Name = name;
            rooms.Add(new Room(patient));
        }
    }
}
