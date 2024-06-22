using System.ComponentModel.DataAnnotations;

namespace FinalApiProject.DTO
{
    public class GraduateTraineeDto
    {
        [Key]
        public int GraduateTraineeId { get; set; }
        public int DegreeId { get; set; }
        public DegreeDto Degree { get; set; }
        public string GraduateTraineeName { get; set; }
        public string GraduateTraineeEmail { get; set; }
        public string UniversityName { get; set; }
        public bool IsLastSemesterPending { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfApplication { get; set; }
        public Byte[]? Image { get; set; }
        public decimal? AI { get; set; }
        public decimal? Python { get; set; }
        public decimal? BusinessAnalysis { get; set; }
        public decimal? MachineLearning { get; set; }
        public decimal? Practical { get; set; }
        public decimal? TotalMarks { get; set; }
        public decimal? Percentages { get; set; }
        public bool? IsAdmissionConfirmed { get; set; }
    }
}
