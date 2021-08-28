using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlNawras.Data;
using AlNawras.Models;
using AutoMapper;
using AlNawras.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace AlNawras.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public ServicesController(IRepo repo, IMapper mapper, DataContext context)
        {
           
            _mapper = mapper;
            _repo = repo;
            _context = context;
        }

        // GET: Services
        [HttpGet]
        public async Task<IActionResult> Index(int requirdPage = 1)
        {
           var result = _repo.GetAllFiles();
           //var result = await _context.Services.ToListAsync();
            var viewData = await GetPaginationData(result, requirdPage);
            return View(viewData);
        }

 

        public async Task<List<ServiceList>> GetPaginationData(IQueryable<ServiceList> data, int requirdPage = 1)
        {
            int pageSize = 3;
            decimal rowsCount = await _repo.GetNumbersOfFiles();
            var pagesCount = Math.Ceiling(rowsCount / pageSize);
            int pageSkip = (requirdPage - 1) * pageSize;

            var ResultData = await data
                            .Skip(pageSkip)
                            .Take(pageSize)
                            .ToListAsync();
            ViewBag.CurruntPage = requirdPage;
            ViewBag.pagesCount = pagesCount;
            return ResultData;
        }


        // GET: Services/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ref,Contractors,ProjectName,Consultant,ContValue")] Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ref,Contractors,ProjectName,Consultant,ContValue")] Service service)
        {
            if (id != service.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(service);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var service = await _context.Services.FindAsync(id);
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(int id)
        {
            return _context.Services.Any(e => e.Id == id);
        }
    }
}
