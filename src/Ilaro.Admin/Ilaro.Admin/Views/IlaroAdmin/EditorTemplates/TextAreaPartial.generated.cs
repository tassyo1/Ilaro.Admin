﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin.Commons.Paging;
    using Ilaro.Admin.Core;
    using Ilaro.Admin.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/EditorTemplates/TextAreaPartial.cshtml")]
    public partial class _Views_IlaroAdmin_EditorTemplates_TextAreaPartial_cshtml_ : System.Web.Mvc.WebViewPage<Property>
    {
        public _Views_IlaroAdmin_EditorTemplates_TextAreaPartial_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\IlaroAdmin\EditorTemplates\TextAreaPartial.cshtml"
  Html.ClearPrefix();
            
            #line default
            #line hidden
WriteLiteral("\r\n<label");

WriteAttribute("for", Tuple.Create(" for=\"", 49), Tuple.Create("\"", 75)
            
            #line 4 "..\..\Views\IlaroAdmin\EditorTemplates\TextAreaPartial.cshtml"
, Tuple.Create(Tuple.Create("", 55), Tuple.Create<System.Object, System.Int32>(Html.Id(Model.Name)
            
            #line default
            #line hidden
, 55), false)
);

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 4 "..\..\Views\IlaroAdmin\EditorTemplates\TextAreaPartial.cshtml"
                                                            Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 4 "..\..\Views\IlaroAdmin\EditorTemplates\TextAreaPartial.cshtml"
                                                                               Write(Html.Condition(Model.IsRequired, () => "<span class=\"text-danger\">*</span>"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n<div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 6 "..\..\Views\IlaroAdmin\EditorTemplates\TextAreaPartial.cshtml"
Write(Html.TextArea(Model.Name, Model.Value.AsString, Model, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 7 "..\..\Views\IlaroAdmin\EditorTemplates\TextAreaPartial.cshtml"
Write(Html.Condition(!string.IsNullOrEmpty(Model.Description), () => "<span class=\"help-block\">" + Model.Description + "</span>"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 9 "..\..\Views\IlaroAdmin\EditorTemplates\TextAreaPartial.cshtml"
Write(Html.ValidationMessage(Model.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
