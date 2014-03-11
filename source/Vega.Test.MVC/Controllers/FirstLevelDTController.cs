﻿using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Vega.Test.Entities.DocumentTypes;
using Vega.USiteBuilder.TemplateBuilder;

namespace Vega.USiteBuilder.MVC.Controllers
{
    public class FirstLevelDTController : TemplateControllerBase<FirstLevelDT>
    {
        public override ActionResult Index()
        {
            //Do some stuff here, then return the base method
            return CurrentTemplate(this.CurrentContent);
        }
    }
}
