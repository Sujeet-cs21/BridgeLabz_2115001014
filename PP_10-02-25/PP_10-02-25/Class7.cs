using System;
using System.Collections.Generic;

namespace PP_10_02_25
{
    // Abstract class Patient
    abstract class Patient
    {
        public string PatientId { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        protected Patient(string patientId, string name, int age)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("Patient ID: " + PatientId + ", Name: " + Name + ", Age: " + Age + ", Bill Amount: " + CalculateBill());
        }
    }

    // Interface IMedicalRecord
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }


    // InPatient class
    class InPatient : Patient, IMedicalRecord
    {
        private List<string> MedicalRecords = new List<string>();
        private double ConsultationFee;

        public InPatient(string patientId, string name, int age, double consultationFee) : base(patientId, name, age)
        {
            ConsultationFee = consultationFee;
        }

        public override double CalculateBill()
        {
            return ConsultationFee;
        }

        public void AddRecord(string record)
        {
            MedicalRecords.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records: " + Name + ": " + string.Join(", ", MedicalRecords));
        }
    }

    // OutPatient class
    class OutPatient : Patient, IMedicalRecord
    {
        private List<string> MedicalRecords = new List<string>();
        private double DailyRate;
        private int DaysAdmitted;

        public OutPatient(string patientId, string name, int age, double dailyRate, int daysAdmitted) : base(patientId, name, age)
        {
            DailyRate = dailyRate;
            DaysAdmitted = daysAdmitted;
        }

        public override double CalculateBill()
        {
            return DailyRate * DaysAdmitted;
        }

        public void AddRecord(string record)
        {
            MedicalRecords.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records: " + Name + ": " + string.Join(", ", MedicalRecords));
        }
    }

    class Class7
    {
        public static void Main7()
        {
            List<Patient> patients = new List<Patient>
            {
                new InPatient("P02", "Patient2", 30, 500),
                new OutPatient("P01", "Patient1", 45, 2000, 5)
            };

            foreach (var patient in patients)
            {
                patient.GetPatientDetails();
            }
        }
    }
}
