using CrudAPI.Data;
using CrudAPI.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDataBaseContext _context;
        public EmployeeController(ApplicationDataBaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        [ProducesResponseType(typeof(EmployeeDetailModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<EmployeeDetailModel>> Get()
        {
            return await _context.EmployeeData.ToListAsync();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(EmployeeDetailModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var result=await _context.EmployeeData.FindAsync(id);
            return result==null? NotFound() : Ok(result);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(EmployeeDetailModel obj)
        {
            /*Content Create Model*/
            await _context.EmployeeData.AddAsync(obj);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { Id = obj.Id }, obj) ;
            /*Content Create Model*/
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id,EmployeeDetailModel obj)
        {
            if (id != obj.Id) return NotFound();
            _context.Entry(obj).State=EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteItem =await _context.EmployeeData.FindAsync(id);
            if (deleteItem == null) return NotFound();
            _context.EmployeeData.Remove(deleteItem);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
