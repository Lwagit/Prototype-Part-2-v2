// Class representing a Lecturer's claim
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contract Monthly Claim System!");

            // Simulating a simple menu
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Submit a Claim");
            Console.WriteLine("2. Exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                // Placeholder for submitting a claim
                Console.WriteLine("You chose to submit a claim.");
            }
            else if (input == "2")
            {
                Console.WriteLine("Exiting the system. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option selected.");
            }
        }
        // Class representing a Lecturer's claim
        public class Claim
        {
            public int ClaimId { get; set; }
            public int LecturerId { get; set; }
            public DateTime SubmissionDate { get; set; }
            public double HoursWorked { get; set; }
            public double HourlyRate { get; set; }
            public string Status { get; set; } // e.g., "Pending", "Approved", "Rejected"

            // Constructor
            public Claim(int claimId, int lecturerId, DateTime submissionDate, double hoursWorked, double hourlyRate, string status)
            {
                ClaimId = claimId;
                LecturerId = lecturerId;
                SubmissionDate = submissionDate;
                HoursWorked = hoursWorked;
                HourlyRate = hourlyRate;
                Status = status;
            }
        }

    }
}







