using FinalApiProject.Data;
using FinalApiProject.DTO;
using FinalApiProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FinalApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraduateTraineeController : ControllerBase
    {
        private readonly IGraduateTraineeRepository _repository;

        public GraduateTraineeController(IGraduateTraineeRepository graduateTraineeRepository)
        {
            _repository = graduateTraineeRepository;
        }

        [HttpPost("Create")]
        public IActionResult CreateGraduateTrainee(CreateGraduateTraineeDto createGraduateTraineeDto)
        {
            var graduateTrainee = new GraduateTrainee
            {
                DegreeId = createGraduateTraineeDto.DegreeId,
                GraduateTraineeName = createGraduateTraineeDto.GraduateTraineeName,
                GraduateTraineeEmail = createGraduateTraineeDto.GraduateTraineeEmail,
                UniversityName = createGraduateTraineeDto.UniversityName,
                IsLastSemesterPending = createGraduateTraineeDto.IsLastSemesterPending,
                Gender = createGraduateTraineeDto.Gender,
                DateOfApplication = createGraduateTraineeDto.DateOfApplication,
                Image = createGraduateTraineeDto.Image,
                AI = createGraduateTraineeDto.AI,
                Python = createGraduateTraineeDto.Python,
                BusinessAnalysis = createGraduateTraineeDto.BusinessAnalysis,
                MachineLearning = createGraduateTraineeDto.MachineLearning,
                Practical = createGraduateTraineeDto.Practical
            };

            // Perform business logic
            graduateTrainee.TotalMarks = graduateTrainee.AI + graduateTrainee.Python +
                                         graduateTrainee.BusinessAnalysis + graduateTrainee.MachineLearning +
                                         graduateTrainee.Practical;

            graduateTrainee.Percentages = (graduateTrainee.TotalMarks / 500) * 100;

            graduateTrainee.IsAdmissionConfirmed = graduateTrainee.Percentages > 60;

            _repository.CreateGraduateTrainee(graduateTrainee);

            var response = new GraduateTraineeDto
            {
                GraduateTraineeId = graduateTrainee.GraduateTraineeId,
                DegreeId = graduateTrainee.DegreeId,
                GraduateTraineeName = graduateTrainee.GraduateTraineeName,
                GraduateTraineeEmail = graduateTrainee.GraduateTraineeEmail,
                UniversityName = graduateTrainee.UniversityName,
                IsLastSemesterPending = graduateTrainee.IsLastSemesterPending,
                Gender = graduateTrainee.Gender,
                DateOfApplication = graduateTrainee.DateOfApplication,
                Image = graduateTrainee.Image,
                AI = graduateTrainee.AI,
                Python = graduateTrainee.Python,
                BusinessAnalysis = graduateTrainee.BusinessAnalysis,
                MachineLearning = graduateTrainee.MachineLearning,
                Practical = graduateTrainee.Practical,
                TotalMarks = graduateTrainee.TotalMarks,
                Percentages = graduateTrainee.Percentages,
                IsAdmissionConfirmed = graduateTrainee.IsAdmissionConfirmed
            };

            return Ok(response);
        }

        [HttpPut("Update/{id}")]
        public IActionResult UpdateGraduateTrainee(int id, CreateGraduateTraineeDto graduateTraineeDto)
        {
            var graduateTrainee = _repository.GetGraduateTraineeById(id);

            if (graduateTrainee == null)
            {
                return NotFound();
            }

            graduateTrainee.GraduateTraineeName = graduateTraineeDto.GraduateTraineeName;
            graduateTrainee.DegreeId = graduateTraineeDto.DegreeId;
            graduateTrainee.GraduateTraineeEmail = graduateTraineeDto.GraduateTraineeEmail;
            graduateTrainee.UniversityName = graduateTraineeDto.UniversityName;
            graduateTrainee.IsLastSemesterPending = graduateTraineeDto.IsLastSemesterPending;
            graduateTrainee.Gender = graduateTraineeDto.Gender;
            graduateTrainee.DateOfApplication = graduateTraineeDto.DateOfApplication;
            graduateTrainee.Image = graduateTraineeDto.Image;
            graduateTrainee.AI = graduateTraineeDto.AI;
            graduateTrainee.Python = graduateTraineeDto.Python;
            graduateTrainee.BusinessAnalysis = graduateTraineeDto.BusinessAnalysis;
            graduateTrainee.MachineLearning = graduateTraineeDto.MachineLearning;
            graduateTrainee.Practical = graduateTraineeDto.Practical;

            // Perform business logic
            graduateTrainee.TotalMarks = graduateTrainee.AI + graduateTrainee.Python +
                                         graduateTrainee.BusinessAnalysis + graduateTrainee.MachineLearning +
                                         graduateTrainee.Practical;

            graduateTrainee.Percentages = (graduateTrainee.TotalMarks / 500) * 100;

            graduateTrainee.IsAdmissionConfirmed = graduateTrainee.Percentages > 60;

            var updatedGraduateTrainee = _repository.UpdateGraduateTrainee(graduateTrainee);

            if (updatedGraduateTrainee == null)
            {
                return NotFound();
            }

            var response = new GraduateTraineeDto
            {
                GraduateTraineeId = updatedGraduateTrainee.GraduateTraineeId,
                DegreeId = updatedGraduateTrainee.DegreeId,
                GraduateTraineeName = updatedGraduateTrainee.GraduateTraineeName,
                GraduateTraineeEmail = updatedGraduateTrainee.GraduateTraineeEmail,
                UniversityName = updatedGraduateTrainee.UniversityName,
                IsLastSemesterPending = updatedGraduateTrainee.IsLastSemesterPending,
                Gender = updatedGraduateTrainee.Gender,
                DateOfApplication = updatedGraduateTrainee.DateOfApplication,
                Image = updatedGraduateTrainee.Image,
                AI = updatedGraduateTrainee.AI,
                Python = updatedGraduateTrainee.Python,
                BusinessAnalysis = updatedGraduateTrainee.BusinessAnalysis,
                MachineLearning = updatedGraduateTrainee.MachineLearning,
                Practical = updatedGraduateTrainee.Practical,
                TotalMarks = updatedGraduateTrainee.TotalMarks,
                Percentages = updatedGraduateTrainee.Percentages,
                IsAdmissionConfirmed = updatedGraduateTrainee.IsAdmissionConfirmed
            };

            return Ok(response);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllGraduateTrainees()
        {
            var graduateTrainees = _repository.GetAllGraduateTrainees();
            return Ok(graduateTrainees);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetGraduateTraineeById(int id)
        {
            var graduateTrainee = _repository.GetGraduateTraineeById(id);

            if (graduateTrainee == null)
            {
                return NotFound();
            }

            var response = new GraduateTraineeDto
            {
                GraduateTraineeId = graduateTrainee.GraduateTraineeId,
                DegreeId = graduateTrainee.DegreeId,
                GraduateTraineeName = graduateTrainee.GraduateTraineeName,
                GraduateTraineeEmail = graduateTrainee.GraduateTraineeEmail,
                UniversityName = graduateTrainee.UniversityName,
                IsLastSemesterPending = graduateTrainee.IsLastSemesterPending,
                Gender = graduateTrainee.Gender,
                DateOfApplication = graduateTrainee.DateOfApplication,
                Image = graduateTrainee.Image,
                AI = graduateTrainee.AI,
                Python = graduateTrainee.Python,
                BusinessAnalysis = graduateTrainee.BusinessAnalysis,
                MachineLearning = graduateTrainee.MachineLearning,
                Practical = graduateTrainee.Practical,
                TotalMarks = graduateTrainee.TotalMarks,
                Percentages = graduateTrainee.Percentages,
                IsAdmissionConfirmed = graduateTrainee.IsAdmissionConfirmed
            };

            return Ok(response);
        }

        [HttpGet("GetGraduateTraineeByName/{name}")]
        public IActionResult GetGraduateTraineeByName(string name)
        {
            var graduateTrainees = _repository.GetGraduateTraineeByName(name);

            if (graduateTrainees == null || !graduateTrainees.Any())
            {
                return NotFound();
            }

            var response = graduateTrainees.Select(graduateTrainee => new GraduateTraineeDto
            {
                GraduateTraineeId = graduateTrainee.GraduateTraineeId,
                DegreeId = graduateTrainee.DegreeId,
                GraduateTraineeName = graduateTrainee.GraduateTraineeName,
                GraduateTraineeEmail = graduateTrainee.GraduateTraineeEmail,
                UniversityName = graduateTrainee.UniversityName,
                IsLastSemesterPending = graduateTrainee.IsLastSemesterPending,
                Gender = graduateTrainee.Gender,
                DateOfApplication = graduateTrainee.DateOfApplication,
                Image = graduateTrainee.Image,
                AI = graduateTrainee.AI,
                Python = graduateTrainee.Python,
                BusinessAnalysis = graduateTrainee.BusinessAnalysis,
                MachineLearning = graduateTrainee.MachineLearning,
                Practical = graduateTrainee.Practical,
                TotalMarks = graduateTrainee.TotalMarks,
                Percentages = graduateTrainee.Percentages,
                IsAdmissionConfirmed = graduateTrainee.IsAdmissionConfirmed
            });

            return Ok(response);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteGraduateTrainee(int id)
        {
            var deletedGraduateTrainee = _repository.DeleteGraduateTrainee(id);

            if (deletedGraduateTrainee == null)
            {
                return NotFound();
            }

            var response = new GraduateTraineeDto
            {
                GraduateTraineeId = deletedGraduateTrainee.GraduateTraineeId,
                DegreeId = deletedGraduateTrainee.DegreeId,
                GraduateTraineeName = deletedGraduateTrainee.GraduateTraineeName,
                GraduateTraineeEmail = deletedGraduateTrainee.GraduateTraineeEmail,
                UniversityName = deletedGraduateTrainee.UniversityName,
                IsLastSemesterPending = deletedGraduateTrainee.IsLastSemesterPending,
                Gender = deletedGraduateTrainee.Gender,
                DateOfApplication = deletedGraduateTrainee.DateOfApplication,
                Image = deletedGraduateTrainee.Image,
                AI = deletedGraduateTrainee.AI,
                Python = deletedGraduateTrainee.Python,
                BusinessAnalysis = deletedGraduateTrainee.BusinessAnalysis,
                MachineLearning = deletedGraduateTrainee.MachineLearning,
                Practical = deletedGraduateTrainee.Practical,
                TotalMarks = deletedGraduateTrainee.TotalMarks,
                Percentages = deletedGraduateTrainee.Percentages,
                IsAdmissionConfirmed = deletedGraduateTrainee.IsAdmissionConfirmed
            };

            return Ok(response);
        }
    }
}
