using _07_FoodShortage.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace _07_FoodShortage.Models
{
    class City
    {
        private List<IIdentifiable> identifiedMembers = new List<IIdentifiable>();
        private List<IBirthable> birthableMembers = new List<IBirthable>();
        private List<INameableBuyer> foodBuyers = new List<INameableBuyer>();

        public int TotalFoodAmount { get => CalculateTotalFoodAmount(); }

        private int CalculateTotalFoodAmount()
        {
            return foodBuyers.Sum(element => element.Food);
        }

        public void AddNewIdentifiable(IIdentifiable newMember)
        {
            identifiedMembers.Add(newMember);
        }

        public void AddNewBirthable(IBirthable newMember)
        {
            birthableMembers.Add(newMember);
        }

        public void AddNewFoodBuyer(INameableBuyer newBuyer)
        {
            foodBuyers.Add(newBuyer);
        }

        public void AddNewCitizen(Citizen newCitizen)
        {
            AddNewIdentifiable(newCitizen);
            AddNewBirthable(newCitizen);
            AddNewFoodBuyer(newCitizen);
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

        public void MemberBuyFood(string name)
        {
            INameableBuyer buyer = foodBuyers.Find(element => element.Name == name);
            buyer?.BuyFood();
        }
    }
}
