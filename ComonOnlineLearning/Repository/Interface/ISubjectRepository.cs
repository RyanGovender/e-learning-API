using ComonOnlineLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.Repository.Interface
{
   public interface ISubjectRepository 
    {
        IEnumerable<Subject> GetAll();
        void Add(Subject subject);
        Subject GetById(int id);
        IEnumerable<Subject> GetSubjectsForGrade(int gradeID);
    }
}
