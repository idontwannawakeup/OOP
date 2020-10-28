using System.Collections.Generic;

namespace _08_MilitaryElite.Interfaces
{
    interface ILeutenantGeneral
    {
        List<IPrivate> Privates { get; set; }
    }
}
