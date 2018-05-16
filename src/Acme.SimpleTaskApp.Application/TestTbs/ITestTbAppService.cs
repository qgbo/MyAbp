using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp
{
    public interface ITestTbAppService : IApplicationService
    {
        Task<ListResultDto<TestTbListDto>> GetAll(GetAllTestTbsInput input);
    }
}
