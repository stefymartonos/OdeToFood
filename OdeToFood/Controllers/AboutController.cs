﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "1+555+555+555";
        }

        public string Address()
        {
            return "USA";
        }
    }
}
