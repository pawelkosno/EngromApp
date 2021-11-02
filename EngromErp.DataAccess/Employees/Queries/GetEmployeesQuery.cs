using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EngromErp.DataAccess.Employees.Queries
{
    public class GetEmployeesQuery : IRequest<List<GetEmployeesQueryResult>>
    {
    }

    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, List<GetEmployeesQueryResult>>
    {
        private readonly EngromErpContext _context;

        public GetEmployeesQueryHandler(EngromErpContext context)
        {
            _context = context;
        }

        public async Task<List<GetEmployeesQueryResult>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Employees.Select(x => new GetEmployeesQueryResult
            {
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToListAsync();
        }
    }

    public class GetEmployeesQueryResult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
