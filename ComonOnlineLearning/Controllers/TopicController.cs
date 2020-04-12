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
    public class TopicController : ControllerBase
    {
        private ITopicRepository _topicRepository;
        public TopicController(ITopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }

        [HttpGet]
        public IEnumerable<Topic> Get()
        {
            return _topicRepository.GetAll();
        }

        [HttpGet("{id}")]
        public IEnumerable<Topic> Get(int id)
        {
            return _topicRepository.GetTopicsForSubject(id);
        }
    }
}