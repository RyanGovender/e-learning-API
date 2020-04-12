using ComonOnlineLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.Repository.Interface
{
    public interface ITopicRepository
    {
        IEnumerable<Topic> GetAll();
        void Add(Topic topic);
        Topic GetById(int id);
        IEnumerable<Topic> GetTopicsForSubject(int id);
    }
}
