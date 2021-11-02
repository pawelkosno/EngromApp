using EngromErp.DataAccess.Employees.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EngromErp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        [Produces(typeof(List<GetEmployeesQueryResult>))]
        public async Task<IActionResult> GetEmployees()
        {
            var result = await _mediator.Send(new GetEmployeesQuery());

            return Ok(result);
        }
    }
}
