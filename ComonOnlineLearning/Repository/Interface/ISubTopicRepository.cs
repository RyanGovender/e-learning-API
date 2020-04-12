using ComonOnlineLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.Repository.Interface
{
   public interface ISubTopicRepository
    {

        IEnumerable<SubTopic> GetAll();
        void Add(SubTopic topic);
        SubTopic GetById(int id);
        IEnumerable<SubTopic> GetSubTopicForTopic(int id);
    }
}
