using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Acme.SimpleTaskApp.TestTbs;
using Microsoft.EntityFrameworkCore;

namespace Acme.SimpleTaskApp.Tasks
{
    public class TestTbAppService : SimpleTaskAppAppServiceBase, ITestTbAppService
    {
        private readonly IRepository<TestTb> _taskRepository;

        public TestTbAppService(IRepository<TestTb> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<ListResultDto<TestTbListDto>> GetAll(GetAllTestTbsInput input)
        {
            var tasks = await _taskRepository
                .GetAll()
                .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<TestTbListDto>(
                ObjectMapper.Map<List<TestTbListDto>>(tasks)
            );
        }
    }
}
