﻿using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class TestHtmlPage : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "A Test";
        public CUITe_HtmlParagraph p = new CUITe_HtmlParagraph("id=para1");
        public CUITe_HtmlUnorderedList list = new CUITe_HtmlUnorderedList("id=unorderedList");
    }
}
