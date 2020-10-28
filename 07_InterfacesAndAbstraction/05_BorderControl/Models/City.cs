using _05_BorderControl.Interfaces;
using System.Collections.Generic;

namespace _05_BorderControl.Models
{
    class City
    {
        private List<IIdentifiable> identifiedMembers = new List<IIdentifiable>();

        public void AddNewIdentifiable(IIdentifiable newMember)
        {
            identifiedMembers.Add(newMember);
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
    }
}
