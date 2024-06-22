using System.ComponentModel.DataAnnotations;

namespace FinalApiProject.Models
{
    public class Degree
    {
        [Key]
        public int DegreeId { get; set; }
        [Required(ErrorMessage = "Degree name is required")]
        [StringLength(20)]
        public string DegreeName { get; set; }
        public ICollection<GraduateTrainee> GraduateTrainees { get; set; }
    }
}
