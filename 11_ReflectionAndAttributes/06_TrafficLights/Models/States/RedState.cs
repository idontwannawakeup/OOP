using _06_TrafficLights.Interfaces;

namespace _06_TrafficLights.Models.States
{
    class RedState : ITrafficLightState
    {
        public void NextState(TrafficLight trafficLight)
        {
            trafficLight.State = new GreenState();
        }

        public override string ToString() => "Red";
    }
}
