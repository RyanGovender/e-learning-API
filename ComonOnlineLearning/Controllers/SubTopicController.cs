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
    public class SubTopicController : ControllerBase
    {
        private ISubTopicRepository _subTopicRepository;
        public SubTopicController(ISubTopicRepository subTopicRepository)
        {
            _subTopicRepository = subTopicRepository;
        }

        [HttpGet]
        public IEnumerable<SubTopic> Get()
        {
            return _subTopicRepository.GetAll();
        }

        [HttpGet("{id}")]
        public IEnumerable<SubTopic> Get(int id)
        {
            return _subTopicRepository.GetSubTopicForTopic(id);
        }
    }
}