using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComonOnlineLearning.Models;
using ComonOnlineLearning.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComonOnlineLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private IGradeRepository _gradeRepository;

        public GradeController(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }

        [HttpGet]
        public IEnumerable<Grade> Get()
        {
            return _gradeRepository.GetAll();
        }

    }
}