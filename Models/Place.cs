using System.Collections.Generic;

namespace Places.Models
{
    public class Place
    {
        private string _city;
        private string _state;
        private string _description;
        private int _id;
        private static List<Place> _instances = new List<Place> {};

        public Place (string city, string state, string description)
        {
            _city = city;
            _state = state;
            _description = description;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public string GetDescription()
        {
          return _description;
        }

        public void SetDescription(string newDescription)
        {
          _description = newDescription;
        }

        public string GetCity()
        {
            return _city;
        }

        public void SetCity(string newCity)
        {
            _city = newCity;
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string newState)
        {
            _state = newState;
        }

        public int GetId()
        {
          return _id;
        }

        public static List<Place> GetAll()
        {
            return _instances;
        }


        public void Save()
        {
            _instances.Add(this);
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Place Find(int searchId)
        {
          return _instances[searchId-1];
        }
    }
}
