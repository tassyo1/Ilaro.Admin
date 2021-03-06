﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin;
    using Ilaro.Admin.Core;
    using Ilaro.Admin.Core.Extensions;
    
    #line 1 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
    using Ilaro.Admin.DataAnnotations;
    
    #line default
    #line hidden
    using Ilaro.Admin.Extensions;
    using Ilaro.Admin.Models;
    using Ilaro.Admin.Models.Paging;
    using Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/IlaroAdmin/Views/Shared/EditorTemplates/FilePartial.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Shared_EditorTemplates_FilePartial_cshtml_ : System.Web.Mvc.WebViewPage<PropertyValue>
    {
        public _Areas_IlaroAdmin_Views_Shared_EditorTemplates_FilePartial_cshtml_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 6 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
        
            
            #line default
            #line hidden
            
            #line 6 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
         if (Model.AsString.IsNullOrWhiteSpace() == false)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"col-md-1\"");

WriteLiteral(" style=\"max-height: 100px\"");

WriteLiteral(" data-role=\"image\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" style=\"max-width: 100px\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
                       var cellValue = new CellValue(Model.Property); 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 11 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
               Write(Html.DisplayFor(m => cellValue, Model.Property.Template.Display));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 14 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n            <div>\r\n                <input");

WriteAttribute("id", Tuple.Create(" id=\"", 595), Tuple.Create("\"", 629)
            
            #line 17 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
, Tuple.Create(Tuple.Create("", 600), Tuple.Create<System.Object, System.Int32>(Html.Id(Model.Property.Name)
            
            #line default
            #line hidden
, 600), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 630), Tuple.Create("\"", 668)
            
            #line 17 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
, Tuple.Create(Tuple.Create("", 637), Tuple.Create<System.Object, System.Int32>(Html.Name(Model.Property.Name)
            
            #line default
            #line hidden
, 637), false)
);

WriteLiteral(" type=\"file\"");

WriteLiteral(" />\r\n\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(" data-role=\"delete-image\"");

WriteLiteral(">Delete</button>\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
           Write(Html.Hidden(Model.Property.Name + "_delete"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 22 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
            
            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
             if (Model.Property.TypeInfo.IsFileStoredInDb == false && Model.Property.FileOptions.NameCreation == NameCreation.UserInput)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" style=\"margin-top: 15px\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-1\"");

WriteLiteral(">Name</label>\r\n                    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">");

            
            #line 26 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
                                     Write(Html.TextBox(Model.Property.Name, Model.Raw, Model.Property, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n");

            
            #line 28 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 31 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
Write(Html.Condition(!string.IsNullOrEmpty(Model.Property.Description), () => "<span class=\"help-block\">" + Model.Property.Description + "</span>"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 33 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\FilePartial.cshtml"
Write(Html.ValidationMessage(Model.Property.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
