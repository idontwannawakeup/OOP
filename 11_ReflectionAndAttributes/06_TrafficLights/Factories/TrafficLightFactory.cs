using _06_TrafficLights.Interfaces;
using _06_TrafficLights.Models;
using System;

namespace _06_TrafficLights.Factories
{
    class TrafficLightFactory
    {
        public TrafficLight CreateTrafficLight(string currentState)
        {
            try
            {
                string statesNamespace = "_06_TrafficLights.Models.States";
                string stateFullTypeName = $"{statesNamespace}.{currentState}State";
                Type stateType = Type.GetType(stateFullTypeName);

                ITrafficLightState state =
                    (ITrafficLightState)Activator.CreateInstance(stateType);

                return new TrafficLight(state);
            }
            catch
            {
                throw new Exception("Invalid state");
            }
        }
    }
}
