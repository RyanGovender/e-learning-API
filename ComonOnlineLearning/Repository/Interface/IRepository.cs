using ComonOnlineLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComonOnlineLearning.Repository.Interface
{
    public interface IRepository
    {
       public IEnumerable<Type> GetAll();
        void Add(Type item);

        Type GetById(int id);
    }
}
