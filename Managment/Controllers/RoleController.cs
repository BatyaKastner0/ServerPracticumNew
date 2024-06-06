using AutoMapper;
using Managment.API.Model;
using Managment.Core.DTO;
using Managment.Core.Entities;
using Managment.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Managment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

            private readonly IRoleService _roleService;
            private readonly IMapper _mapper;
            public RoleController(IRoleService roleService, IMapper mapper)
            {
                _roleService = roleService;
                _mapper = mapper;
            }
            [HttpGet]
            public async Task<ActionResult> Get()
            {
                var role = await _roleService.GetAllAsync();
                return Ok(_mapper.Map<IEnumerable<RoleDTO>>(role));
                //);
                //var role = new EmployeeRole() { Id = 1 };
                //return Ok(_mapper.Map<EmployeeRolePostModel>(role));

                //var role = new Role() { Name = "kuj"};
                //return Ok(_mapper.Map<RoleDTO>(role));


            }
            [HttpGet("{id}")]
            public async Task<ActionResult> Get(string id)
            {
                var role = await _roleService.GetByIdAsync(id);
                if (role == null)
                {
                    return NotFound();
                }
                return Ok(role);
            }
            [HttpPost]
            public async Task<ActionResult> Post([FromBody] RolePostModel model)
            {
                //check if parentId exists
                var roleToUpdate = await _roleService.AddAsync(_mapper.Map<Role>(model));
                return Ok(roleToUpdate);
            }

            [HttpPut("{id}")]
            public async Task<ActionResult> Put(string id, [FromBody] RolePostModel model)
            {
                var role = await _roleService.GetByIdAsync(id);
                if (role is null)
                {
                    return NotFound();
                }
                _mapper.Map(model, role);
                await _roleService.UpdateAsync(role);
                //employee = await _employeeService.GetByIdAsync(id);
                return Ok(role);

            }
            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(string id)
            {
                var role = await _roleService.GetByIdAsync(id);
                if (role is null)
                {
                    return NotFound();
                }
                await _roleService.RemoveAsync(id);
                return NoContent();
            }
        }
    }


