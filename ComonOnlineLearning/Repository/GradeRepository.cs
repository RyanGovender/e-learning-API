using ComonOnlineLearning.Models;
using ComonOnlineLearning.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.Repository
{
    public class GradeRepository : IGradeRepository
    {
        private ComosOnlineDBContext _dbContext = new ComosOnlineDBContext();
        public void Add(Grade grade)
        {
            _dbContext.Grade.Add(grade);
            _dbContext.SaveChanges();
        }
     
        public IEnumerable<Grade> GetAll()
        {
            return _dbContext.Grade.FromSqlRaw("GetAllGrades").ToArray();
        }

        public Grade GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(_dbContext !=null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
