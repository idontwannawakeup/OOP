namespace _08_MilitaryElite.Models
{
    class Repair
    {
        public string PartName { get; set; }
        public int HoursWorked { get; set; }

        public override string ToString()
            => $"Part Name: {PartName} Hours Worked: {HoursWorked}";

        public Repair(string partName, string hoursWorked)
            : this(partName, int.Parse(hoursWorked))
        { }

        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }
    }
}
