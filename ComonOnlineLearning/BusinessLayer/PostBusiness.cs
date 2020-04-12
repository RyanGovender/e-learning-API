
using ComonOnlineLearning.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.BusinessLayer
{
    public class PostBusiness
    {
        private readonly ComosOnlineDBContext _dBContext = new ComosOnlineDBContext();
        public IEnumerable<Post> Get()
        {
            var param = new SqlParameter("SubTopicID", 1);
            return _dBContext.Post.FromSqlRaw("GetContentForSubtopic @SubTopicID", param).ToList();
        }
    }
}
