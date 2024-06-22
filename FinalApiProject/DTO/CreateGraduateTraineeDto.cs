namespace FinalApiProject.DTO
{

        public class CreateGraduateTraineeDto
        {
            public int DegreeId { get; set; }
            public string GraduateTraineeName { get; set; }
            public string GraduateTraineeEmail { get; set; }
            public string UniversityName { get; set; }
            public bool IsLastSemesterPending { get; set; }
            public string? Gender { get; set; }
            public DateTime DateOfApplication { get; set; }
            public Byte[]? Image { get; set; }
            public decimal? AI { get; set; }
            public decimal? Python { get; set; }
            public decimal? BusinessAnalysis { get; set; }
            public decimal? MachineLearning { get; set; }
            public decimal? Practical { get; set; }
        }
    

}
