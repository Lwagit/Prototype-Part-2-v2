using System;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal class Class1
        {
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
}


