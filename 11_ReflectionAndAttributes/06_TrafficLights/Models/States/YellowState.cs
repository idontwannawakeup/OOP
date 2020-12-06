using _06_TrafficLights.Interfaces;

namespace _06_TrafficLights.Models.States
{
    class YellowState : ITrafficLightState
    {
        public void NextState(TrafficLight trafficLight)
        {
            trafficLight.State = new RedState();
        }

        public override string ToString() => "Yellow";
    }
}
