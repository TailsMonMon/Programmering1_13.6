using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_13._6 {
    class CityTemperature {

        private string cityName = "";
        private int cityTemp = 0;

        public CityTemperature(int tempratureCity, string nameCity) {
            this.cityTemp = tempratureCity;
            this.cityName = nameCity;
        }

        public string Name {
            get {
                return cityName;
            }
            set {
                cityName = value;
            }
        }
       
        public int Temprature {
            get {
                return cityTemp;
            }
            set {
                cityTemp = value;
            }
        }
    }
}
