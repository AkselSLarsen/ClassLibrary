using System;

namespace ClassLibrary {
    public class FootballPlayer {
        private int _id;
        private string _name;
        private float _price;
        private int _shirtNumber;

        public int Id {
            get { return _id; }
            set { _id = value; }
        }

        public string Name {
            get { return _name; }
            set {
                if (value.Length < 4) {
                    throw new ArgumentException("Name in FootballPlayer must be at least 4 characters long.");
                }
                _name = value;
            }
        }

        public float Price {
            get { return _price; }
            set {
                if (value <= 0) {
                    throw new ArgumentException("Price in FootballPlayer must be more than zero.");
                }
                _price = value;
            }
        }

        public int ShirtNumber {
            get { return _shirtNumber; }
            set { 
                if(value < 1 || value > 100) {
                    throw new ArgumentException("ShirtNumber in FootballPlayer must be 1, 100 or anything in between.");
                }
                _shirtNumber = value;
            }
        }

        public FootballPlayer(int id, string name, float price, int shirtNumber) {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;
        }
        
    }
}
