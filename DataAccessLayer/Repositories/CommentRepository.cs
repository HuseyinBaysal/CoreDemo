﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    //IGenericDal Ortak Interface'den Miras Alınır ve T için parametre istenen class'a Entity tanımlanır. 
    public class CommentRepository : IGenericDal<Comment>
    {
        public void Delete(Comment item)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Comment item)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment item)
        {
            throw new NotImplementedException();
        }
    }
}
