using System;


namespace adv_csharp_animals
{
    public abstract class Pet
    {
        protected String _name;

        protected Pet(string name)
        {
            _name = name;
        }

        public virtual string Display()
        {
            return $"{_name}";
        }
    }

    class Dog : Pet
    {
        private Boolean _friendly;

        public Dog(string name, bool friendly) : base(name)
        {
            _friendly = friendly;
        }

        public override string Display()
        {
            return $"{_name}, {_friendly}"; 
        }
    }

    class Cat : Pet
    {
        private int _mousesKilled;

        public Cat(string name, int mousesKilled) : base(name)
        {
            _mousesKilled = mousesKilled;
        }

        public override string Display()
        {
            return $"{_name}, {_mousesKilled}";
        }
    }
}