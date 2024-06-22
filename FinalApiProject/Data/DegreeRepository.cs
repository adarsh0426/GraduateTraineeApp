using FinalApiProject.Models;

namespace FinalApiProject.Data
{
    public class DegreeRepository : IDegreeRepository
    {
        private readonly DataContext _context;

        public DegreeRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Degree> GetDegrees()
        {
            var degrees = _context.Degrees.ToList();
            return degrees;
        }
    }
}
