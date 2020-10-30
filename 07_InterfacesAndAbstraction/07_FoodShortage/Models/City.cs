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
            => foodBuyers.Sum(element => element.Food);

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

        public IEnumerable<IIdentifiable> DetectMembersWithFakeId(string fakeId)
            => identifiedMembers.Where(element => element.Id.EndsWith(fakeId));

        public IEnumerable<IBirthable> GetMembersWithSameBirthYear(int year)
            => birthableMembers.Where(element => element.Birthdate.Year == year);

        public void MemberBuyFood(string name)
        {
            INameableBuyer buyer = foodBuyers.Find(element => element.Name == name);
            buyer?.BuyFood();
        }
    }
}
