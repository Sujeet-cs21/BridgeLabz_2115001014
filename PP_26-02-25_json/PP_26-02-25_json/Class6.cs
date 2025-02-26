using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PP_26_02_25_json
{
    class Class6
    {
        public static void Main6()
        {
            // Creating a list of Car objects
            var cars = new List<Car>
        {
            new Car { Make = "Toyota", Model = "Camry", Year = 2022 },
            new Car { Make = "Honda", Model = "Civic", Year = 2021 },
            new Car { Make = "Ford", Model = "Mustang", Year = 2023 }
        };

            // Convert list of objects to JSON array
            string jsonArray = JsonConvert.SerializeObject(cars, Formatting.Indented);

            // Display JSON array
            Console.WriteLine("JSON Array:\n" + jsonArray);
        }
    }
}
