using _06_BirthdayCelebrations.Interfaces;

namespace _06_BirthdayCelebrations.Models
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
