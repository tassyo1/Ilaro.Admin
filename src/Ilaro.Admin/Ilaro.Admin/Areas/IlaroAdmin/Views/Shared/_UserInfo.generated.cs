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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin;
    using Ilaro.Admin.Core;
    using Ilaro.Admin.Extensions;
    using Ilaro.Admin.Models;
    using Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/IlaroAdmin/Views/Shared/_UserInfo.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Shared__UserInfo_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_IlaroAdmin_Views_Shared__UserInfo_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\IlaroAdmin\Views\Shared\_UserInfo.cshtml"
 if (User.Identity.IsAuthenticated)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">\r\n");

            
            #line 4 "..\..\Areas\IlaroAdmin\Views\Shared\_UserInfo.cshtml"
        
            
            #line default
            #line hidden
            
            #line 4 "..\..\Areas\IlaroAdmin\Views\Shared\_UserInfo.cshtml"
         if (AdminInitialise.Authorize != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 7 "..\..\Areas\IlaroAdmin\Views\Shared\_UserInfo.cshtml"
           Write(User.Identity.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 9 "..\..\Areas\IlaroAdmin\Views\Shared\_UserInfo.cshtml"
            using (Html.BeginForm("Logout", "Account", new { area = "IlaroAdmin" }, FormMethod.Post, new { @class = "nav-item" }))
            {
                
            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\IlaroAdmin\Views\Shared\_UserInfo.cshtml"
           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\IlaroAdmin\Views\Shared\_UserInfo.cshtml"
                                        


            
            #line default
            #line hidden
WriteLiteral("                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-link\"");

WriteLiteral(">Sign out</button>\r\n");

            
            #line 14 "..\..\Areas\IlaroAdmin\Views\Shared\_UserInfo.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 17 "..\..\Areas\IlaroAdmin\Views\Shared\_UserInfo.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591