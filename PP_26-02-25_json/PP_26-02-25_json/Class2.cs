using System;
using Newtonsoft.Json;

namespace PP_26_02_25_json
{
    // Car class
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    class Class2
    {
        public static void Main2()
        {
            // Creating a Car object
            var car = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2022
            };

            // Convert Car object to JSON
            string json = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine("Car in JSON format:\n" + json);
        }
    }

}
