using Acme.SimpleTaskApp.Tasks;
using Acme.SimpleTaskApp.TestTbs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Acme.SimpleTaskApp.Web.Models.TestTbs
{
    public class IndexViewModel
    {
        public IReadOnlyList<TestTbListDto> TaskTbs { get; }

        public IndexViewModel(IReadOnlyList<TestTbListDto> tasks)
        {
            TaskTbs = tasks;
        }

        public string GetTaskLabel(TestTbListDto taskTb)
        {
            switch (taskTb.State)
            {
                case TaskState.Open:
                    return "label-success";
                default:
                    return "label-default";
            }
        }
    }
}
