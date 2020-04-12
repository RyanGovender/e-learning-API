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
    public class SubjectController : ControllerBase
    {
        private ISubjectRepository _subjectRepository;
        public SubjectController(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        [HttpGet("{id}")]
        public IEnumerable<Subject> Get(int id)
        {
            return _subjectRepository.GetSubjectsForGrade(id);
        }
    }
}