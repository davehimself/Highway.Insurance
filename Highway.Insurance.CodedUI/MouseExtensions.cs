﻿using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace Highway.Insurance.CodedUI
{
    public static class MouseExtensions
    { 
        public static void Click(this HtmlControl control)
        {
            Mouse.Click(control);
        }
    }
}