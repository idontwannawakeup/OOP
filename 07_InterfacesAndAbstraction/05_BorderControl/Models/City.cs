using _05_BorderControl.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace _05_BorderControl.Models
{
    class City
    {
        private List<IIdentifiable> identifiedMembers = new List<IIdentifiable>();

        public void AddNewIdentifiable(IIdentifiable newMember)
        {
            identifiedMembers.Add(newMember);
        }

        public IEnumerable<IIdentifiable> DetectMembersWithFakeId(string fakeId)
            => identifiedMembers.Where(element => element.Id.EndsWith(fakeId));
    }
}
