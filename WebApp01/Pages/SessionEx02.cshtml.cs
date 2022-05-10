﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class SessionEx02Model : PageModel
    {
        public void OnGet()
        {
            HttpContext.Session.Clear();
        }
    }
}
