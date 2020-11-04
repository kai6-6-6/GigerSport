﻿using GigerSport.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GigerSport.Repository
{
    public class GigerSportRepository<T> where T : class
    {
        public GigerSportDB _context;
        public GigerSportRepository(GigerSportDB context)
        {
            if (context == null)
            {
                throw new ArgumentException();
            }
            _context = context;
        }
        public void Create(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }
    }
}