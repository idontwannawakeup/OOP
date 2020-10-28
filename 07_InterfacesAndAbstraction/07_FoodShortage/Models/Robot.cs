using _07_FoodShortage.Interfaces;

namespace _07_FoodShortage.Models
{
    class Robot : IIdentifiable
    {
        public string Model { get; set; }
        public string Id { get; set; }

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}
