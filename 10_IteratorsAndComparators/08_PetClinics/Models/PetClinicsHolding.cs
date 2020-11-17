using System;
using System.Collections.Generic;
using System.Text;

namespace _08_PetClinics.Models
{
    class PetClinicsHolding
    {
        private List<Pet> pets = new List<Pet>();
        private List<PetClinic> clinics = new List<PetClinic>();

        public void TryCreate(string[] info)
        {
            if (info[1] == "Clinic")
                TryCreateClinic(info);
            else
                pets.Add(new Pet(info[2], info[3], info[4]));
        }

        public void TryCreateClinic(string[] info)
        {
            try
            {
                clinics.Add(new PetClinic(info[2], info[3]));
            }
            catch
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        public bool TryAddPet(string petsName, string clinicsName)
        {
            var pet = pets.Find(element => element.Name == petsName);
            var clinic = clinics.Find(element => element.Name == clinicsName);

            if (pet == null || clinic == null)
                return false;

            return clinic.Add(pet);
        }

        public bool TryRelease(string clinicsName)
        {
            var clinic = clinics.Find(element => element.Name == clinicsName);
            if (clinic == null)
                return false;

            return clinic.Release();
        }

        public bool HasEmptyRooms(string clinicsName)
        {
            var clinic = clinics.Find(element => element.Name == clinicsName);
            if (clinic == null)
                return false;

            return clinic.HasEmptyRooms();
        }

        public void Print(string[] info)
        {
            var clinic = clinics.Find(element => element.Name == info[1]);
            if (clinic == null)
                Console.WriteLine("No such clinic!");

            if (info.Length == 2)
                clinic.Print();
            else
                clinic.Print(int.Parse(info[2]) - 1);
        }
    }
}
