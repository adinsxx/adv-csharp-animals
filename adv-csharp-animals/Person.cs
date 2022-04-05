using System;

namespace adv_csharp_animals
{
    public class Person
    {
        private String _name;

        public Person(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}