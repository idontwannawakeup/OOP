using System;
using System.Collections.Generic;
using System.Text;

namespace _01_EventImplementation.Models
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

    class Dispatcher
    {
        public event NameChangeEventHandler NameChange;

        private string name;

        public string Name
        {
            get => name;

            set
            {
                OnNameChange(new NameChangeEventArgs(value));
                name = value;
            }
        }

        private void OnNameChange(NameChangeEventArgs args)
        {
            NameChange?.Invoke(this, args);
        }
    }
}
