using AutoMapper;
using AutoMapper.QueryableExtensions;
using AlNawras.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using AlNawras.Dtos;

namespace AlNawras.Data
{
    public class Repo : IRepo
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public Repo(DataContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<int> GetNumbersOfFiles()
        {

            return await _db.Services.CountAsync();
        }

        public  IQueryable<ServiceList> GetAllFiles()
        {
            var result = _db.Services.OrderByDescending(t => t.Ref).ProjectTo<ServiceList>(_mapper.ConfigurationProvider);

            return result;
        }

    }
}
