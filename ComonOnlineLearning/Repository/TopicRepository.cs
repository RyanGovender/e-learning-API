using ComonOnlineLearning.BusinessLayer;
using ComonOnlineLearning.Models;
using ComonOnlineLearning.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.Repository
{
    public class TopicRepository : ITopicRepository
    {
        private ComosOnlineDBContext _dbContext = new ComosOnlineDBContext();
        private SqlBusiness _sqlBusiness;
        private static string _GetSubjectTopicForChoosenGradeProcParameterName = "GradeSubjectID";
        private static string _GetSubjectTopicForChoosenGrade = "GetSubjectTopicForChoosenGrade";
        public TopicRepository(SqlBusiness sqlBusiness)
        {
            _sqlBusiness = sqlBusiness;
        }
        public void Add(Topic topic)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Topic> GetAll()
        {
           return _dbContext.Topic.ToList();
        }

        public Topic GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Topic> GetTopicsForSubject(int id)
        {
            return _dbContext.Topic.FromSqlRaw(_sqlBusiness.JoinSqlParameterToStoreProc(_GetSubjectTopicForChoosenGrade,_GetSubjectTopicForChoosenGradeProcParameterName)
                ,_sqlBusiness.SetSqlParameter(_GetSubjectTopicForChoosenGradeProcParameterName,id))
                .ToArray();
        }
    }
}
