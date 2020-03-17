using System.Collections.Generic;

namespace AnimalShelter.Models
{
    public class Type
    {
        private static List<Type> _types = new List<Type>{ };
        public string Name { get; set ;}
        public int Id {get; }
        public List<Animal> Animals {get; set;}

        public Type(string typeName)
        {
            Name = typeName;
            _types.Add(this);
            Id = _types.Count;
            Animals = new List<Animal>{};
        }

        public static void ClearAll()
        {
        _types.Clear();
        }

        public static List<Type> GetAll()
        {
        return _types;
        }

        public static Type Find(int searchId)
        {
        return _types[searchId - 1];
        }


        public void AddItem(Animal animal)
        {
        Animal.Add(animal);
        }
    }
}