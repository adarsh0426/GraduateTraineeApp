using System;
using System.ComponentModel.DataAnnotations;

namespace FinalApiProject.Models
{
    public class GraduateTrainee
    {
        public int GraduateTraineeId { get; set; }

        [Required(ErrorMessage = "DegreeId is required.")]
        public int DegreeId { get; set; }
        public Degree Degree { get; set; }

        [Required(ErrorMessage = "GraduateTraineeName is required.")]
        public string GraduateTraineeName { get; set; }

        [Required(ErrorMessage = "GraduateTraineeEmail is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string GraduateTraineeEmail { get; set; }

        [Required(ErrorMessage = "UniversityName is required.")]
        public string UniversityName { get; set; }

        public bool IsLastSemesterPending { get; set; }

        [StringLength(10, ErrorMessage = "Gender cannot exceed 10 characters.")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "DateOfApplication is required.")]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid date format.")]
        public DateTime DateOfApplication { get; set; }

        public byte[]? Image { get; set; }

        // Last Semester marks
        [Range(0, 100, ErrorMessage = "AI should be between 0 and 100.")]
        public decimal? AI { get; set; }

        [Range(0, 100, ErrorMessage = "Python should be between 0 and 100.")]
        public decimal? Python { get; set; }

        [Range(0, 100, ErrorMessage = "BusinessAnalysis should be between 0 and 100.")]
        public decimal? BusinessAnalysis { get; set; }

        [Range(0, 100, ErrorMessage = "MachineLearning should be between 0 and 100.")]
        public decimal? MachineLearning { get; set; }

        [Range(0, 100, ErrorMessage = "Practical should be between 0 and 100.")]
        public decimal? Practical { get; set; }

        // Calculated fields
        public decimal? TotalMarks { get; set; }
        public decimal? Percentages { get; set; }
        public bool? IsAdmissionConfirmed { get; set; }
    }
}
