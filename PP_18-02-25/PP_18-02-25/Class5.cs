using System;
using System.Collections.Generic;

namespace PP_18_02_25
{
    // Abstract Class for Job Roles
    public abstract class JobRole
    {
        public string RoleName { get; set; }
    }

    // Specific Job Roles
    public class SoftwareEngineer : JobRole
    {
        public SoftwareEngineer() { RoleName = "Software Engineer"; }
    }

    public class DataScientist : JobRole
    {
        public DataScientist() { RoleName = "Data Scientist"; }
    }

    // Interface for Resume
    public interface IResume
    {
        void DisplayResume();
    }

    // Generic Resume Class Implementing IResume
    public class Resume<T> : IResume where T : JobRole
    {
        public string CandidateName { get; set; }
        public T JobPosition { get; set; }
        public int ExperienceYears { get; set; }
        public string Skills { get; set; }

        public Resume(string candidateName, T jobPosition, int experienceYears, string skills)
        {
            CandidateName = candidateName;
            JobPosition = jobPosition;
            ExperienceYears = experienceYears;
            Skills = skills;
        }

        public void DisplayResume()
        {
            Console.WriteLine("Candidate: " + CandidateName + ", Role: " + JobPosition.RoleName + ", Experience: " + ExperienceYears + " years, Skills: " + Skills);
        }
    }

    // Resume Screening System
    public class ResumeScreeningSystem
    {
        private List<IResume> resumes = new List<IResume>();

        // Generic Method to Process Resumes
        public void AddResume<T>(Resume<T> resume) where T : JobRole
        {
            resumes.Add(resume);
        }

        // Display All Resumes
        public void DisplayResumes()
        {
            Console.WriteLine("\n--- Resume Screening Results ---");
            foreach (var resume in resumes)
            {
                resume.DisplayResume();
            }
        }
    }

    // Main Program
    class Class5
    {
        public static void Main5()
        {
            // Create Job Roles
            SoftwareEngineer seRole = new SoftwareEngineer();
            DataScientist dsRole = new DataScientist();

            // Create Resumes
            Resume<SoftwareEngineer> resume1 = new Resume<SoftwareEngineer>("Candidate1", seRole, 5, "C#, .NET, SQL");
            Resume<DataScientist> resume2 = new Resume<DataScientist>("Candidate2", dsRole, 3, "Python, Machine Learning, SQL");

            // Resume Screening System
            ResumeScreeningSystem screeningSystem = new ResumeScreeningSystem();
            screeningSystem.AddResume(resume1);
            screeningSystem.AddResume(resume2);

            // Display All Resumes
            screeningSystem.DisplayResumes();
        }
    }

}
