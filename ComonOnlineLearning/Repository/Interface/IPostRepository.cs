using ComonOnlineLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.Repository.Interface
{
   public interface IPostRepository
    {
        IEnumerable<Post> GetAll();
        void Add(Post topic);
        Post GetById(int id);
        IEnumerable<Post> GetContentForSubTopic(int id);
    }
}
