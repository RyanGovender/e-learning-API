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
    public class PostRepository : IPostRepository
    {
        private ComosOnlineDBContext _dbContext = new ComosOnlineDBContext();
        private SqlBusiness _sqlBusiness;
        private static string _getContentForSubtopic = "GetContentForSubtopic";
        private static string _GetContentForSubtopicParamName = "SubTopicID";

        public PostRepository(SqlBusiness sqlBusiness)
        {
            _sqlBusiness = sqlBusiness;
        }
        public void Add(Post topic)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            return _dbContext.Post.ToList();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetContentForSubTopic(int id)
        {
            return _dbContext.Post.FromSqlRaw(_sqlBusiness.JoinSqlParameterToStoreProc(
                _getContentForSubtopic,_GetContentForSubtopicParamName)
                ,_sqlBusiness.SetSqlParameter(_GetContentForSubtopicParamName,id)).ToList();
        }
    }
}
