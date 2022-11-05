using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    public class Car
    { 
        //Deafult Contructor
        public Car()
        {
        }
        //Custom Constructor
        public Car(int Year, string make, string model, string engineNoise, string honkNoise, bool IsDriveable)
        {
            Year = Year;
            make = make;
            model = model;
            engineNoise = engineNoise;
            honkNoise = honkNoise;
            IsDriveable = IsDriveable;

        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string model { get; set; }
        public string engineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"This car goes {engineNoise}");
        }
        
        public void MakeHornNoise(string hornNoise)
        {
            Console.WriteLine($"This horn sound is {hornNoise}");
        }
    }

}
