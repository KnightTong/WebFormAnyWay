﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormAnyWay
{
    public partial class PersonGrid : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        internal GridView GridView
        {
            get { return personGrid; }
        }
    }
}