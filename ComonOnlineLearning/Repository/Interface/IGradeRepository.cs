using ComonOnlineLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.Repository.Interface
{
   public interface IGradeRepository
    {
        IEnumerable<Grade> GetAll();
        void Add(Grade grade);
        Grade GetById(int id);
    }
}
