#pragma checksum "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80f723c6dc1c2f04fe2259627b0d1d271bc990df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AlbumView), @"mvc.1.0.view", @"/Views/Home/AlbumView.cshtml")]
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
#line 1 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\_ViewImports.cshtml"
using ImageHosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\_ViewImports.cshtml"
using ImageHosting.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80f723c6dc1c2f04fe2259627b0d1d271bc990df", @"/Views/Home/AlbumView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3333cc77701a4a12909ef3d83003f1927f90fcf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AlbumView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImageHosting.Models.AlbumView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveAlbum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadFilesToBlobStorage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPermissions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
   ViewData["Title"] = Model.name; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
 if (User.Identity.IsAuthenticated)
{
      bool isAdmin = Model.permission_level == 2;

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n    <h1>This album is called ");
#nullable restore
#line 9 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
                        Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h1>\n");
#nullable restore
#line 10 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
         if(isAdmin)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Your are administrator of this album.</h2>\r\n");
#nullable restore
#line 13 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
        } else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Your access is read-only.</h2>\r\n");
#nullable restore
#line 16 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
     if(isAdmin) {

#line default
#line hidden
#nullable disable
            WriteLiteral("     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f723c6dc1c2f04fe2259627b0d1d271bc990df7987", async() => {
                WriteLiteral("DELETE ALBUM AND ALL PHOTOS INSIDE");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-albumid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
                                        WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["albumid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-albumid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["albumid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 19 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 21 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
    if(isAdmin)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #parent {
        display: flex;
    }

    #narrow {
        width: 50%;
        background: lightblue;
    }

    #wide {
        width: 50%;
        background: lightgreen;
        }
</style>
<div id=""parent"">
    <div id=""wide"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f723c6dc1c2f04fe2259627b0d1d271bc990df11090", async() => {
                WriteLiteral(@"
            <div>
                <div class=""col-md-10"" style=""padding-top:10px; padding-bottom:10px;"">
                    <div>
                        <label>Upload more photos to your album:</label>
                        <input type=""file"" name=""files"" multiple />
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-10"" style=""padding-top:5px;"">
                        <input type=""submit"" value=""Upload"" />
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-albumid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
                                                                                                       WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["albumid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-albumid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["albumid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n\n    <div id=\"narrow\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f723c6dc1c2f04fe2259627b0d1d271bc990df14552", async() => {
                WriteLiteral("\n            <div class=\"form-group\">\n                <div class=\"col-md-10\">\n                    <p>Add permissions:</p>\n                    <input type=\"text\" name=\"email\" />\n                    <label for=\"access\">Choose access level to add: </label>\n\n");
#nullable restore
#line 67 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
                       List<SelectListItem> listItems = new List<SelectListItem>();
                        listItems.Add(new SelectListItem
                        {
                            Text = "Read Access",
                            Value = "1",
                            Selected = true
                        });
                        listItems.Add(new SelectListItem
                        {
                            Text = "Admin Access",
                            Value = "2"

                        }); 

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
#nullable restore
#line 80 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
               Write(Html.DropDownList("access", listItems, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div class=""form-group"">
                    <div class=""col-md-10"">
                        <input type=""submit"" value=""Add permission"" />
                    </div>
                </div>
            </div>

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-albumid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
                                                                                             WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["albumid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-albumid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["albumid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\r\n");
#nullable restore
#line 92 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <style>\r\n    #item {\r\n        display: inline-block;\r\n        width: 200px;\r\n        background: white;\r\n        padding-left:15px;\r\n        padding-right:15px;\r\n    }\r\n    #buttons {\n        width:200px;\n        display: grid;\n    }\r\n\n</style>\n");
#nullable restore
#line 109 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
     if (Model.photoList.Any())
    {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
             foreach (var item in Model.photoList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3302, "\"", 3326, 1);
#nullable restore
#line 115 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
WriteAttributeValue("", 3308, item.blob_address, 3308, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" length=\"200\">\r\n                    <div id=\"buttons\">\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3444, "\"", 3505, 6);
            WriteAttributeValue("", 3454, "javascript:", 3454, 11, true);
            WriteAttributeValue(" ", 3465, "window.location", 3466, 16, true);
            WriteAttributeValue(" ", 3481, "=", 3482, 2, true);
            WriteAttributeValue(" ", 3483, "\'", 3484, 2, true);
#nullable restore
#line 117 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
WriteAttributeValue("", 3485, item.blob_address, 3485, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3503, "\';", 3503, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Download</a>\n");
#nullable restore
#line 118 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
                         if (isAdmin)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f723c6dc1c2f04fe2259627b0d1d271bc990df21844", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-photoid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
                                                                                      WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["photoid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-photoid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["photoid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
                                                                                                                     WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["albumid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-albumid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["albumid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 121 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 124 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
             
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2>Your album is empty</h2>\n");
#nullable restore
#line 129 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <error statusCode=\"403\" />\n");
#nullable restore
#line 134 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\AlbumView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script>
        function DisplayFilesToUpload() {
            var element = document.getElementById(""file"");
            var html = """";

            html = ""<h3>Image(s) to Upload</h3>""
            for (var i = 0; i < element.files.length; i++) {
                html += ""<strong>"" + (i + 1) + ""</strong>. File: "";
                var file = element.files[i];
                if ('name' in file) { html += file.name + "" (""; }
                if ('size' in file) { html += ""size: "" + file.size + "" bytes)<br>""; }
            }

            html += ""<div class='fileUpload btn btn-default'><span>Upload</span><input type='submit' class='upload' value='Upload'/></div>""
            document.getElementById(""FilesToUpload"").innerHTML = html;
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImageHosting.Models.AlbumView> Html { get; private set; }
    }
}
#pragma warning restore 1591
