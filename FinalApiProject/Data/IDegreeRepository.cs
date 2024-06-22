using FinalApiProject.Models;

namespace FinalApiProject.Data
{
    public interface IDegreeRepository
    {

        IEnumerable<Degree> GetDegrees();

    }
}
