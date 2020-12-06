using _06_TrafficLights.Interfaces;

namespace _06_TrafficLights.Models
{
    class TrafficLight
    {
        public ITrafficLightState State { get; set; }

        public void NextState() => State.NextState(this);

        public override string ToString() => State.ToString();

        public TrafficLight(ITrafficLightState state)
        {
            State = state;
        }
    }
}
