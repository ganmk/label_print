using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.Mvc;
using label_print.ViewModel.HomeVMs;
using label_print.Model;

namespace label_print.Controllers
{
    public class LabelController : BaseController
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public dynamic PutLabel(string label)
        {
            LabelTemplateModel _labelTemplateModel = new LabelTemplateModel();
            _labelTemplateModel.LabelJson = label;
            DC.AddEntity(_labelTemplateModel);
            int rows=  DC.SaveChanges();
            return null;
        }
    }
}
