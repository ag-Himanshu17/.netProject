#pragma checksum "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e00a910edb426e6f0dbbbbfb41ff4e9e5420508b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_ShareApproval), @"mvc.1.0.view", @"/Views/Data/ShareApproval.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00a910edb426e6f0dbbbbfb41ff4e9e5420508b", @"/Views/Data/ShareApproval.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a505e16aedebba3dbdad36d89debd774180803f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Data_ShareApproval : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ShareModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Approved", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Data", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
  
    ViewData["Title"] = "ShareApproval";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
 if (TempData["SuccessMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"alert alert-success\">\r\n\t\t");
#nullable restore
#line 8 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
   Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n");
#nullable restore
#line 10 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
	<div class=""col-xs-12"">
		<div class=""box"">
			<div class=""box-header"">
				<h1>Shared File Approval</h1>
			</div>
			<div class=""box-body"">
				<table class=""table table-bordered table-hover"">
					<thead>
						<tr>
							<th>S.No.</th>
							<th>FileName</th>
							<th>View File</th>
							<th>ReciverId</th>
							<th>Status</th>
						</tr>
					</thead>
					<tbody>
");
#nullable restore
#line 29 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
                          
							int i = 1;
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
                         foreach (var item in Model)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 35 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 36 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
                               Write(item.Data.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
                                 if (!string.IsNullOrEmpty(item.Data.FileName))
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e00a910edb426e6f0dbbbbfb41ff4e9e5420508b7390", async() => {
                WriteLiteral("<i class=\"fa fa-eye\"></i>View");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 858, "~/uploads/", 858, 10, true);
#nullable restore
#line 39 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
AddHtmlAttributeValue("", 868, item.Data.FileName, 868, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 40 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 41 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
                               Write(item.Reciever.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e00a910edb426e6f0dbbbbfb41ff4e9e5420508b9590", async() => {
                WriteLiteral("Approve");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 46 "D:\Project Training\GroupA\CollegeProject\CollegeProject\Views\Data\ShareApproval.cshtml"
							{
								i++;
							}
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</tbody>\r\n\t\t\t\t</table>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
