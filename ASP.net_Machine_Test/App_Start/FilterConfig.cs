﻿using System.Web;
using System.Web.Mvc;

namespace ASP.net_Machine_Test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
