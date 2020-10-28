using _08_MilitaryElite.Models;
using System.Collections.Generic;

namespace _08_MilitaryElite.Interfaces
{
    interface IEngineer
    {
        List<Repair> Repairs { get; set; }
    }
}
