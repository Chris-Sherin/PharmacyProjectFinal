#pragma checksum "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\Prof\ViewProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9f791e4cbe96b0797e1c7d5bee4b16afc588eaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prof_ViewProfile), @"mvc.1.0.view", @"/Views/Prof/ViewProfile.cshtml")]
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
#line 1 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\_ViewImports.cshtml"
using PharmClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\_ViewImports.cshtml"
using PharmClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9f791e4cbe96b0797e1c7d5bee4b16afc588eaf", @"/Views/Prof/ViewProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f0616a20e9fd4aaa5aec99911234fa91657038d", @"/Views/_ViewImports.cshtml")]
    public class Views_Prof_ViewProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PharmClient.Models.CustomerDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Productdetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Prod", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\Prof\ViewProfile.cshtml"
  
    ViewData["Title"] = "ViewProfile";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9f791e4cbe96b0797e1c7d5bee4b16afc588eaf4373", async() => {
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    #viewdiv {
        width: 380px;
        padding: 60px;
        height: 530px;
        margin: auto;
        /*overflow: hidden;
        margin: auto;
        margin: 20 0 0 400px;
        padding: 70px;*/
        text-align: center;
        background-image: linear-gradient(to right,#A2ECE6,#24B3A8,#1D8D84);
        border-radius: 15px;
    }
    input:hover[type=""submit""] {
        border-radius: 20%;
        border: none;
        border-color: bisque;
        background-color: antiquewhite;
    }

    input.slide-hover-left-1 {
        background-image: linear-gradient(0, #156760, #156760);
        background-size: 0;
        transition: .8s;
        background-repeat: no-repeat;
    }

        input.slide-hover-left-1:hover {
            background-size: 100%;
            color: #fff;
        }

    button:hover[type=""submit""] {
        border-radius: 20%;
        border: none;
        border-color: bisque;
        background-color: antiquewhite;
    }

    button.slide-hover-left-1 {
       ");
            WriteLiteral(@" background-image: linear-gradient(0, #156760, #156760);
        background-size: 0;
        transition: .8s;
        background-repeat: no-repeat;
    }

        button.slide-hover-left-1:hover {
            background-size: 100%;
            color: #fff;
        }
</style>

<div class=""row justify-content-center"" id=""viewdiv"">
    <i class=""fa fa-user"" style=""font-size: 50px; color: white;align-content:center;""></i>
    &nbsp;&nbsp;&nbsp;
    <h1 style=""text-align: center; color: #A2ECE6; font-size: 40px; "">Profile</h1>
    <dl class=""row justify-content-center"">
        <dt class=""col-sm-2"" style=""color: #1D8D84;"">
            Id
        </dt>
        <dd class=""col-sm-10"" style=""color:white;"">
            ");
#nullable restore
#line 71 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\Prof\ViewProfile.cshtml"
       Write(Html.DisplayFor(model => model.Userid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\" style=\"color: #1D8D84;\">\n            Username\n        </dt>\n        <dd class=\"col-sm-10\" style=\"color:white;\">\n            ");
#nullable restore
#line 77 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\Prof\ViewProfile.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\" style=\"color: #1D8D84;\">\n            Gender\n        </dt>\n        <dd class=\"col-sm-10\" style=\"color:white;\">\n            ");
#nullable restore
#line 83 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\Prof\ViewProfile.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\" style=\"color: #1D8D84;\">\n            Age\n        </dt>\n        <dd class=\"col-sm-10\" style=\"color:white;\">\n            ");
#nullable restore
#line 89 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\Prof\ViewProfile.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\" style=\"color: #1D8D84;\">\n            Address\n        </dt>\n        <dd class=\"col-sm-10\" style=\"color:white;\">\n            ");
#nullable restore
#line 95 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\Prof\ViewProfile.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\" style=\"color: #1D8D84;\">\n            Email\n        </dt>\n        <dd class=\"col-sm-10\" style=\"color:white;\">\n            ");
#nullable restore
#line 101 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\Prof\ViewProfile.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\" style=\"color: #1D8D84;\">\n            Phone\n        </dt>\n        <dd class=\"col-sm-10\" style=\"color:white;\">\n            ");
#nullable restore
#line 107 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\Prof\ViewProfile.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n");
            WriteLiteral("    </dl>\n    <div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9f791e4cbe96b0797e1c7d5bee4b16afc588eaf10155", async() => {
                WriteLiteral("<button class=\"btn btn-primary slide-hover-left-1\" style=\"background-color: #1D8D84; border: none; padding: 7px 30px; color: white\">Edit</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "D:\Pharmacy Final\pharmclient-main\pharmclient-main\Views\Prof\ViewProfile.cshtml"
                                      WriteLiteral(Model.Userid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        &nbsp;&nbsp;&nbsp;&nbsp;\n        &nbsp;&nbsp;&nbsp;&nbsp;\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9f791e4cbe96b0797e1c7d5bee4b16afc588eaf12529", async() => {
                WriteLiteral("<button class=\"btn btn-primary slide-hover-left-1\" style=\"background-color: #1D8D84; border: none; padding: 7px 30px; color: white\">Back</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PharmClient.Models.CustomerDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
