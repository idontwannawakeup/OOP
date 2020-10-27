using System.Collections.Generic;

namespace _05_BorderControl
{
    class City
    {
        private List<IIdentifiable> society = new List<IIdentifiable>();

        public void AddNewMember(IIdentifiable newMember)
        {
            society.Add(newMember);
        }

        public List<IIdentifiable> DetectMembersWithFakeIds(string fakeId)
        {
            var result = new List<IIdentifiable>();
            foreach (var item in society)
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
