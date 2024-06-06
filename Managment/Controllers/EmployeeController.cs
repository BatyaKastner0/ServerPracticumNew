using AutoMapper;
using Managment.API.Model;
using Managment.Core.DTO;
using Managment.Core.Entities;
using Managment.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Managment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeService employeeService,IMapper mapper)
        {
            _employeeService=employeeService;
            _mapper=mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var employees = await _employeeService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<EmployeeDTO>>(employees));

        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<EmployeeDTO>(employee));
        }
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> Post([FromBody] EmployeePostModel model)
        {
            //check if parentId exists
            var employeeToUpdate = await _employeeService.AddAsync(_mapper.Map<Employee>(model));
            return Ok(_mapper.Map<Employee>(employeeToUpdate));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, [FromBody] EmployeePostModel model)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            if (employee is null)
            {
                return NotFound();
            }
            _mapper.Map(model, employee);
            await _employeeService.UpdateAsync(employee);
            //employee = await _employeeService.GetByIdAsync(id);
            return Ok(employee);

        }
        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(string id)
        //{
        //    var employee = await _employeeService.GetByIdAsync(id);
        //    if (employee is null)
        //    {
        //        return NotFound();
        //    }
        //    await _employeeService.RemoveAsync(id);
        //    return NoContent();
        //}
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var employee = await _employeeService.GetByIdAsync(id);

            if (employee is null)
            {
                return NotFound();
            }
            employee.IsActive = false;
            await _employeeService.UpdateAsync(employee); // Update the employee to set IsActive to false
            return NoContent();
        }
    }
}
