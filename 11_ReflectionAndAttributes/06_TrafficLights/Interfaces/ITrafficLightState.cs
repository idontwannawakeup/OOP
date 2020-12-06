using _06_TrafficLights.Models;

namespace _06_TrafficLights.Interfaces
{
    interface ITrafficLightState
    {
        void NextState(TrafficLight trafficLight);
    }
}
