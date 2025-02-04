using System;

namespace PP_04_02_25
{
    class Patient
    {
        // Static variable shared among all patients
        public static string HospitalName = "AIIMS";

        // Static variable to track total patients
        private static int totalPatients = 0;

        // Readonly variable for Patient ID
        public readonly int PatientID;

        // Patient details
        public string Name;
        public int Age;
        public string Ailment;

        // Constructor
        public Patient(int PatientID, string Name, int Age, string Ailment)
        {
            // Using 'this' to initialize fields
            this.PatientID = PatientID;
            this.Name = Name;
            this.Age = Age;
            this.Ailment = Ailment;

            totalPatients++;
        }

        // Static method to get total patients
        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients Admitted: " + totalPatients);
            Console.WriteLine("********************");
        }

        // Method to display patient details
        public void DisplayPatientDetails()
        {
            // Using 'is' operator to check instance type
            if (this is Patient)
            {
                Console.WriteLine("Hospital Name: " + HospitalName);
                Console.WriteLine("Patient ID: " + PatientID);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Ailment: " + Ailment);
                Console.WriteLine("********************");
            }
            else
            {
                Console.WriteLine("Invalid patient object.");
            }
        }
        public static void RunPatientClass()
        {
            // Creating patient instances
            Patient patient1 = new Patient(101, "Patient1", 30, "Flu");
            Patient patient2 = new Patient(102, "Patient2", 45, "Diabetes");

            // Display patient details
            patient1.DisplayPatientDetails();
            patient2.DisplayPatientDetails();

            // Display total patients admitted
            Patient.GetTotalPatients();
        }
    }
}
