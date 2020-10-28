using System;

namespace _08_MilitaryElite.Models
{
    class Mission
    {
        public enum MissionState
        {
            inProgress,
            Finished
        }

        public string CodeName { get; set; }
        public MissionState State { get; set; }

        public void CompleteMission() { State = MissionState.Finished; }

        public override string ToString()
            => $"Code Name: {CodeName} State: {State}";

        public Mission(string codeName, string state)
            : this(codeName, (MissionState) Enum.Parse(typeof(MissionState), state))
        { }

        public Mission(string codeName, MissionState state)
        {
            CodeName = codeName;
            State = state;
        }
    }
}
