using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Acme.SimpleTaskApp.Tasks;
using Acme.SimpleTaskApp.TestTbs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.SimpleTaskApp
{
    [AutoMapFrom(typeof(TestTb))]
    public class TestTbListDto : EntityDto, IHasCreationTime
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }
    }
}
