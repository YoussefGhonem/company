using AlNawras.Dtos;
using AlNawras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlNawras.Data
{
    public interface IRepo
    {
      

        IQueryable<ServiceList> GetAllFiles();
        Task<int> GetNumbersOfFiles();

    }
}
