#pragma checksum "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f70e58a16053301cf586a1470ab6c00acc160677"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_ShareInfo), @"mvc.1.0.view", @"/Views/Data/ShareInfo.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\_ViewImports.cshtml"
using CollegeProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\_ViewImports.cshtml"
using CollegeProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f70e58a16053301cf586a1470ab6c00acc160677", @"/Views/Data/ShareInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a505e16aedebba3dbdad36d89debd774180803f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Data_ShareInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ShareModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml"
  
    ViewData["Title"] = "ShareInfo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
	<div class=""col-xs-12"">
		<div class=""box"">
			<div class=""box-header"">
				<h1>Shared File Staatus</h1>
			</div>
			<div class=""box-body"">
				<table class=""table table-bordered table-hover"">
					<thead>
						<tr>
							<th>S.No.</th>
							<th>FileName</th>
							<th>ReciverId</th>
							<th>Status</th>
						</tr>
					</thead>
					<tbody>
");
#nullable restore
#line 22 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml"
                          
							int i = 1;
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml"
                         foreach (var item in Model)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 28 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 29 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml"
                               Write(item.Data.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 30 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml"
                               Write(item.Reciever.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>\r\n");
#nullable restore
#line 32 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml"
                                     if (item.IsCompleted)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<a class=\"btn btn-success btn-xs\">Sent</a>\r\n");
#nullable restore
#line 35 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml"
									}
									else
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<a class=\"btn btn-primary btn-xs\">Pending</a>\r\n");
#nullable restore
#line 39 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 42 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareInfo.cshtml"
							{
								i++;
							}
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</tbody>\r\n\t\t\t\t</table>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ShareModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
