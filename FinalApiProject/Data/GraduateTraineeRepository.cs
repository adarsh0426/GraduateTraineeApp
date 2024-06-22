using FinalApiProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace FinalApiProject.Data
{
    public class GraduateTraineeRepository : IGraduateTraineeRepository
    {
        private readonly DataContext _context;

        public GraduateTraineeRepository(DataContext context)
        {
            _context = context;
        }

        public GraduateTrainee CreateGraduateTrainee(GraduateTrainee graduateTrainee)
        {
            if (!AlreadyExists(graduateTrainee.GraduateTraineeEmail, graduateTrainee.GraduateTraineeId))
            {
                _context.GraduateTrainees.Add(graduateTrainee);
                _context.SaveChanges();
                return graduateTrainee;
            }
            else
            {
                return null;
            }
        }

        public GraduateTrainee UpdateGraduateTrainee(GraduateTrainee graduateTrainee)
        {
            if (!AlreadyExists(graduateTrainee.GraduateTraineeEmail, graduateTrainee.GraduateTraineeId))
            {
                var updatedGraduateTrainee = _context.GraduateTrainees.Find(graduateTrainee.GraduateTraineeId);
                if (updatedGraduateTrainee != null)
                {
                    // Update other properties as needed
                    _context.SaveChanges();
                    return updatedGraduateTrainee;
                }
            }
            return null;
        }

        public GraduateTrainee DeleteGraduateTrainee(int id)
        {
            var graduateTrainee = _context.GraduateTrainees.Find(id);
            if (graduateTrainee != null)
            {
                _context.GraduateTrainees.Remove(graduateTrainee);
                _context.SaveChanges();
                return graduateTrainee;
            }
            return null;
        }

        public IEnumerable<GraduateTrainee> GetAllGraduateTrainees()
        {
            var graduateTrainees = _context.GraduateTrainees.ToList();
            return graduateTrainees;
        }

        public GraduateTrainee GetGraduateTraineeById(int id)
        {
            var graduateTrainee = _context.GraduateTrainees.Find(id);
            return graduateTrainee;
        }

        public IEnumerable<GraduateTrainee> GetGraduateTraineeByName(string name)
        {
            var graduateTrainees = _context.GraduateTrainees.Where(g => g.GraduateTraineeName.Contains(name)).ToList();
            return graduateTrainees;
        }

        public bool AlreadyExists(string email, int graduateTraineeId = 0)
        {
            var graduateTrainees = _context.GraduateTrainees.ToList();
            var result = false;
            if (graduateTraineeId == 0 && graduateTrainees != null)
            {
                result = graduateTrainees.Any(c => c.GraduateTraineeEmail == email);
            }
            else
            {
                result = graduateTrainees.Any(c => c.GraduateTraineeId != graduateTraineeId && c.GraduateTraineeEmail == email);
            }
            return result;
        }
    }
}
