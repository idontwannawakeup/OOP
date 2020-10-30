using _06_BirthdayCelebrations.Interfaces;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<IIdentifiable> DetectMembersWithFakeId(string fakeId)
            => identifiedMembers.Where(element => element.Id.EndsWith(fakeId));

        public IEnumerable<IBirthable> GetMembersWithSameBirthYear(int year)
            => birthableMembers.Where(element => element.Birthdate.Year == year);
    }
}
