using System;
using System.Collections.Generic;
using System.Text;

namespace _08_PetClinics.Models
{
    class PetClinic
    {
        public string Name { get; set; }

        private Pet[] roomsOfPets;
        private int middle;

        public void Print(int roomIdx)
        {
            PrintRoom(roomsOfPets[roomIdx]);
        }

        public void Print()
        {
            foreach (var item in roomsOfPets)
                PrintRoom(item);
        }

        public bool Add(Pet item)
        {
            var roomToFillEnumerator = GetRoomToFillEnumerator();
            roomToFillEnumerator.MoveNext();
            
            // if room is taken, move to next idx
            while (roomsOfPets[roomToFillEnumerator.Current] != null)
            {
                // if we reach the end and empty room not found return false
                if (!roomToFillEnumerator.MoveNext())
                    return false;
            }

            roomsOfPets[roomToFillEnumerator.Current] = item;
            return true;
        }

        public bool Release()
        {
            for (int i = middle; i < roomsOfPets.Length; i++)
                if (roomsOfPets[i] != null)
                {
                    roomsOfPets[i] = null;
                    return true;
                }

            for (int i = 0; i < middle; i++)
                if (roomsOfPets[i] != null)
                {
                    roomsOfPets[i] = null;
                    return true;
                }

            return false;
        }

        public bool HasEmptyRooms()
        {
            foreach (var item in roomsOfPets)
                if (item == null)
                    return true;

            return false;
        }

        private void PrintRoom(Pet roomWithPet)
        {
            if (roomWithPet == null)
                Console.WriteLine("Room empty");
            else
                Console.WriteLine(roomWithPet);
        }

        private IEnumerator<int> GetRoomToFillEnumerator()
        {
            yield return middle;

            for (int i = 1; i <= middle; i++)
            {
                yield return middle - i;
                yield return middle + i;
            }
        }

        public PetClinic(string name, string roomsAmount)
            : this(name, int.Parse(roomsAmount))
        { }

        public PetClinic(string name, int roomsAmount)
        {
            if (roomsAmount % 2 == 0)
                throw new Exception();

            Name = name;
            roomsOfPets = new Pet[roomsAmount];
            middle = roomsAmount / 2;
        }
    }
}
