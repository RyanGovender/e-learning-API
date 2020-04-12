using ComonOnlineLearning.BusinessLayer;
using ComonOnlineLearning.Models;
using ComonOnlineLearning.Repository.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        private ComosOnlineDBContext _dbContext = new ComosOnlineDBContext();
        private SqlBusiness _sqlBusiness;
        private static string _GetSubjectsForGradeStoredProcParameterName = "GradeID";
        private static string _GetSubjectsForGradeStoredProc = "GetSubjectsForThatGrade";
        public SubjectRepository(SqlBusiness sqlBusiness)
        {
            _sqlBusiness = sqlBusiness;
        }
     
        public void Add(Subject subject)
        {
            _dbContext.Subject.Add(subject);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Subject> GetAll()
        {
            return _dbContext.Subject.ToList();
        }

        public Subject GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> GetSubjectsForGrade(int gradeID)
        {
            return _dbContext.Subject.FromSqlRaw(_sqlBusiness.JoinSqlParameterToStoreProc(_GetSubjectsForGradeStoredProc,
                _GetSubjectsForGradeStoredProcParameterName), _sqlBusiness.SetSqlParameter(_GetSubjectsForGradeStoredProcParameterName,gradeID))
                .ToList();
        }
    }
}
