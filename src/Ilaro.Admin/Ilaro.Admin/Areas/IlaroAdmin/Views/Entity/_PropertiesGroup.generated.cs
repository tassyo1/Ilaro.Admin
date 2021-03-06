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
    using Ilaro.Admin.Extensions;
    using Ilaro.Admin.Models;
    using Ilaro.Admin.Models.Paging;
    using Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/IlaroAdmin/Views/Entity/_PropertiesGroup.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Entity__PropertiesGroup_cshtml : System.Web.Mvc.WebViewPage<GroupProperties>
    {

#line 18 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
public System.Web.WebPages.HelperResult ToggleIconClass(bool isCollapsed)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 19 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
  
    if (isCollapsed) {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");

WriteLiteralTo(__razor_helper_writer, "glyphicon-plus");

WriteLiteralTo(__razor_helper_writer, " ");


#line 20 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
                                                   }
    else {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");

WriteLiteralTo(__razor_helper_writer, "glyphicon-minus");

WriteLiteralTo(__razor_helper_writer, " ");


#line 21 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
                                        }


#line default
#line hidden
});

#line 22 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
}
#line default
#line hidden

#line 24 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
public System.Web.WebPages.HelperResult Toggle(bool isCollapsed)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 25 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
 
    if (isCollapsed) {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");

WriteLiteralTo(__razor_helper_writer, "style=\"display:none\"");

WriteLiteralTo(__razor_helper_writer, " ");


#line 26 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
                                                         }


#line default
#line hidden
});

#line 27 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
}
#line default
#line hidden

        public _Areas_IlaroAdmin_Views_Entity__PropertiesGroup_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<fieldset>\r\n    <legend>\r\n");

WriteLiteral("        ");

            
            #line 5 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
   Write(Model.GroupName);

            
            #line default
            #line hidden
WriteLiteral(" \r\n        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn pull-right\"");

WriteLiteral(">\r\n            <span");

WriteAttribute("class", Tuple.Create(" class=\"", 151), Tuple.Create("\"", 204)
, Tuple.Create(Tuple.Create("", 159), Tuple.Create("glyphicon", 159), true)
            
            #line 7 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
, Tuple.Create(Tuple.Create(" ", 168), Tuple.Create<System.Object, System.Int32>(ToggleIconClass(Model.IsCollapsed)
            
            #line default
            #line hidden
, 169), false)
);

WriteLiteral("></span>\r\n        </button>\r\n    </legend>\r\n    <div");

WriteLiteral(" class=\"fields\"");

WriteLiteral(" ");

            
            #line 10 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
                   Write(Toggle(Model.IsCollapsed));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 11 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
        
            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\IlaroAdmin\Views\Entity\_PropertiesGroup.cshtml"
         foreach (var propertyValue in Model.PropertiesValues)
        {
            Html.RenderPartial("_PropertyEditor", propertyValue);
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</fieldset>\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
