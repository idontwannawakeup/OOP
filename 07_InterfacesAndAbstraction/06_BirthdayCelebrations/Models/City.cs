using _06_BirthdayCelebrations.Interfaces;
using System.Collections.Generic;

namespace _06_BirthdayCelebrations.Models
{
    class City
    {
        private List<IIdentifiable> identifiedMembers = new List<IIdentifiable>();
        private List<IBirthable> birthableMembers = new List<IBirthable>();

        public void AddNewIdentifiable(IIdentifiable newMember)
        {
            identifiedMembers.Add(newMember);
        }

        public void AddNewBirthable(IBirthable newMember)
        {
            birthableMembers.Add(newMember);
        }

        public void AddNewCitizen(Citizen newCitizen)
        {
            AddNewIdentifiable(newCitizen);
            AddNewBirthable(newCitizen);
        }

        public List<IIdentifiable> DetectMembersWithFakeIds(string fakeId)
        {
            var result = new List<IIdentifiable>();
            foreach (var item in identifiedMembers)
            {
                var id = item.Id;
                if (id.Length >= fakeId.Length &&
                    id.Substring(id.Length - fakeId.Length, fakeId.Length) == fakeId)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public List<IBirthable> GetMembersWithSameBirthYear(int year)
        {
            var result = new List<IBirthable>();
            foreach (var item in birthableMembers)
                if (item.Birthdate.Year == year)
                    result.Add(item);

            return result;
        }
    }
}
