using FinalApiProject.Models;

namespace FinalApiProject.Data
{
    public interface IGraduateTraineeRepository
    {
        GraduateTrainee CreateGraduateTrainee(GraduateTrainee graduateTrainee);
        GraduateTrainee UpdateGraduateTrainee(GraduateTrainee graduateTrainee);
        GraduateTrainee DeleteGraduateTrainee(int id);
        IEnumerable<GraduateTrainee> GetAllGraduateTrainees();
        GraduateTrainee GetGraduateTraineeById(int id);
        IEnumerable<GraduateTrainee> GetGraduateTraineeByName(string name);
    }
}
