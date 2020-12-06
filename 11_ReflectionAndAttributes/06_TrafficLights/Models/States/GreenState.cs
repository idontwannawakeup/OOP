using _06_TrafficLights.Interfaces;

namespace _06_TrafficLights.Models.States
{
    class GreenState : ITrafficLightState
    {
        public void NextState(TrafficLight trafficLight)
        {
            trafficLight.State = new YellowState();
        }

        public override string ToString() => "Green";
    }
}
