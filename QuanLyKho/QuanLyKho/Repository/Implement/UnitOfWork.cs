﻿using QuanLyKho.Model;
using QuanLyKho.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Repository.Implement
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The DbContext
        /// </summary>
        private QuanLyKhoData _dbContext;

        /// <summary>
        /// Initializes a new instance of the UnitOfWork class.
        /// </summary>
        /// <param name="context">The object context</param>
        public UnitOfWork(QuanLyKhoData context)
        {
            _dbContext = context;
        }
        public QuanLyKhoData GetDataBase()
        {
            return _dbContext;
        }
        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }


    }
}
