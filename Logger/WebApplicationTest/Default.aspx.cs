﻿using LogHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(new Logger().logPath);

            String errorMessage = "PRUEBA LOG TEST";

            new Logger().log(errorMessage);

        }
    }
}