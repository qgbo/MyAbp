using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.SimpleTaskApp.Controllers;
using Acme.SimpleTaskApp.Web.Models.TestTbs;
using Microsoft.AspNetCore.Mvc;

namespace Acme.SimpleTaskApp.Web.Mvc.Controllers
{
    public class TestTbsController : SimpleTaskAppControllerBase
    {
        private readonly ITestTbAppService _taskAppService;

        public TestTbsController(ITestTbAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public async Task<ActionResult> Index(GetAllTestTbsInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model =  new IndexViewModel(output.Items);
            return View(model);
        }
    }
}