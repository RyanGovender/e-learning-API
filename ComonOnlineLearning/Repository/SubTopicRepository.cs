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
    public class SubTopicRepository : ISubTopicRepository
    {
        private ComosOnlineDBContext _dbContext = new ComosOnlineDBContext();
        private SqlBusiness _sqlBusiness;
        private static string _GetSubtopicsForTopicProcParameterName = "TopicID";
        private static string _GetSubtopicsForTopic = "GetSubtopicsForTopic";

        public SubTopicRepository(SqlBusiness sqlBusiness)
        {
            _sqlBusiness = sqlBusiness;
        }
        public void Add(SubTopic topic)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubTopic> GetAll()
        {
            return _dbContext.SubTopic.ToList();
        }

        public SubTopic GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubTopic> GetSubTopicForTopic(int id)
        {
            return _dbContext.SubTopic.FromSqlRaw(_sqlBusiness.JoinSqlParameterToStoreProc(_GetSubtopicsForTopic,_GetSubtopicsForTopicProcParameterName)
                ,_sqlBusiness.SetSqlParameter(_GetSubtopicsForTopicProcParameterName,id)).ToList();
        }
    }
}
