using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Dto;
using TaskManager.Entity.Foundation;

namespace TaskManager.Controllers;

public class BranchController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public BranchController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Update(BranchDto branchDto)
    {
        var branch = _mapper.Map<Branch>(branchDto);

        if (branch.Id == 0)
            _context.Branches.Add(branch);
        else
            _context.Branches.Update(branch);

        _context.SaveChanges();

        return new OkResult();
    }

    public IActionResult GetList(int page = 1)
    {
        if (page < 1)
            page = 1;
        
        var branches = _context.Branches.Where(x=>x.DeletedAt == null).ToList();

        return new ObjectResult(branches);
    }

    public IActionResult Delete(long id)
    {
        var entity = _context.Branches.Find(id);

        if (entity != null)
        {
            entity.DeletedAt = DateTime.Now;

            _context.Update(entity);
            _context.SaveChanges();
            
            return new OkResult();
        }

        return new BadRequestResult();
    }
}