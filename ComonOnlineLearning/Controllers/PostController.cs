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
    public class PostController : ControllerBase
    {
        private IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _postRepository.GetAll();
        }

        [HttpGet("{id}")]
        public IEnumerable<Post> Get(int id)
        {
            return _postRepository.GetContentForSubTopic(id);
        }
    }
}