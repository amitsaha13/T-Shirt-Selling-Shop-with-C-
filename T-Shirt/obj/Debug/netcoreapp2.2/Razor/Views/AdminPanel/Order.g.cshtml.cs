#pragma checksum "G:\CSE 3.2\C# lab\project\T-Shirt\T-Shirt\Views\AdminPanel\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6af51418c452c7f82f61d9912345ef9056100301"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Order), @"mvc.1.0.view", @"/Views/AdminPanel/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Order.cshtml", typeof(AspNetCore.Views_AdminPanel_Order))]
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
#line 1 "G:\CSE 3.2\C# lab\project\T-Shirt\T-Shirt\Views\_ViewImports.cshtml"
using T_Shirt;

#line default
#line hidden
#line 2 "G:\CSE 3.2\C# lab\project\T-Shirt\T-Shirt\Views\_ViewImports.cshtml"
using T_Shirt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6af51418c452c7f82f61d9912345ef9056100301", @"/Views/AdminPanel/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3196cc98e7db788f1d5150a647d575fdf3c4fcba", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminPanel_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("from-container from-container mt-6 mb-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("InsertProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/pictures/logo1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\CSE 3.2\C# lab\project\T-Shirt\T-Shirt\Views\AdminPanel\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
            BeginContext(43, 37, true);
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(80, 1214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6af51418c452c7f82f61d9912345ef90561003016837", async() => {
                BeginContext(86, 1201, true);
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
    <link rel=""styleshe");
                WriteLiteral("et\" href=\"https://use.fontawesome.com/releases/v5.7.0/css/all.css\" integrity=\"sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ\" crossorigin=\"anonymous\">\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1294, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1298, 6197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6af51418c452c7f82f61d9912345ef90561003019302", async() => {
                BeginContext(1304, 148, true);
                WriteLiteral("\r\n\r\n\r\n    <div class=\"container\">\r\n\r\n        <div class=\"text-center\" style=\"padding-bottom:5%\">\r\n            <h1>Dear Customer Your Total bill is: ");
                EndContext();
                BeginContext(1453, 21, false);
#line 27 "G:\CSE 3.2\C# lab\project\T-Shirt\T-Shirt\Views\AdminPanel\Order.cshtml"
                                             Write(ViewData["TotalBill"]);

#line default
#line hidden
                EndContext();
                BeginContext(1474, 85, true);
                WriteLiteral("</h1>\r\n        </div>\r\n\r\n        <div class=\"container text-right\">\r\n\r\n\r\n            ");
                EndContext();
                BeginContext(1559, 2146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6af51418c452c7f82f61d9912345ef905610030110333", async() => {
                    BeginContext(1680, 2018, true);
                    WriteLiteral(@"

                <div class=""form-group"">
                    
                    
                    
                    <div class=""row"" style=""padding-bottom:1%;"">
                        <div class=""col-md-3"">
                            <label class=""font-weight-bold"">Your name</label>
                        </div>
                        <div class=""col-md-7"">
                            <input name=""name"" type=""text"" class=""form-control "" rows=""0"" placeholder=""Enter your name"">
                        </div>
                    </div>
                    <div class=""row"" style=""padding-bottom:1%;"">
                        <div class=""col-md-3"">
                            <label class=""font-weight-bold"" style=""padding-right:2%;"">Current Address</label>
                        </div>
                        <div class=""col-md-7"">
                            <input name=""address"" type=""text"" class=""form-control"" id=""name"" placeholder=""Enter current address"">
                     ");
                    WriteLiteral(@"   </div>
                    </div>
                    <div class=""row"" style=""padding-bottom:1%;"">
                        <div class=""col-md-3"">
                            <label class=""font-weight-bold"">Phone number</label>
                        </div>
                        <div class=""col-md-7"">
                            <input name=""quantity"" type=""text"" class=""form-control"" id="""" placeholder=""Enter phone noumber"">
                        </div>
                    </div>
                    

                    <div class=""row"" style=""padding-bottom:1%;"">
                        <div class=""col-md-10"">
                            <div class=""modal-footer border-top-0 d-flex justify-content-lg-end"">
                                <button type=""submit"" name=""insert"" class=""btn btn-dark btn-lg"">Submit</button>
                            </div>
                        </div>
                    </div>





                </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3705, 563, true);
                WriteLiteral(@"
        </div>

    </div>



    <footer class=""page-footer font-small unique-color-dark"">



        <!-- Footer Links -->
        <div class=""container-fluid text-center text-md-left mt-5"" style=""background-color: black; color:white;"">

            <!-- Grid row -->
            <div class=""row mt-3"">

                <!-- Grid column -->
                <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"" style=""padding-top:25px;"">

                    <!-- Content -->
                    <h6 class=""text-uppercase font-weight-bold"">");
                EndContext();
                BeginContext(4268, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6af51418c452c7f82f61d9912345ef905610030115051", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4348, 3140, true);
                WriteLiteral(@"</h6>
                    <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
                    <p>
                        Here you can use rows and columns to organize your footer content. Lorem ipsum dolor sit amet,
                        consectetur
                        adipisicing elit.
                    </p>

                </div>

                <div class=""col-md-2 col-lg-2 col-xl-2 mx-auto mb-4"" style=""padding-top:10px;>

                    <!-- Links -->
                    <h6 class=""text-uppercase font-weight-bold"">Products</h6>
                    <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
                    <p>
                        <a href=""#!"">MDBootstrap</a>
                        </br>
                        <a href=""#!"">MDWordPress</a>
                        </br>
                        <a href=""#!"">BrandFlow</a>
                    </p>


                </div>
      ");
                WriteLiteral(@"          <!-- Grid column -->
                <!-- Grid column -->
                <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mb-4"" style=""padding-top:10px;>

                    <!-- Links -->
                    <h6 class=""text-uppercase font-weight-bold"">Useful links</h6>
                    <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
                    <p>
                        <a href=""#!"">Your Account</a>
                        </br>
                        <a href=""#!"">Shipping Rates</a>
                        </br>
                        <a href=""#!"">Help</a>
                        </br>
                        <a href=""#!"">Terms & Conditions</a>
                        </br>
                        <a href=""#!"">Privacy</a>
                    </p>

                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4"" styl");
                WriteLiteral(@"e=""padding-top:10px;>

                    <!-- Links -->
                    <h3 class=""text-uppercase font-weight-bold"">Contact</h3>
                    <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
                    <p>
                        <i class=""fas fa-home mr-3""></i> 101,102 Love Road,Dhaka</br>

                        <i class=""fas fa-envelope mr-3""></i> info@example.com</br>

                        <i class=""fas fa-phone mr-3""></i> +088 01686 00 11 99
                    </p>


                </div>
                <!-- Grid column -->

            </div>
            <!-- Grid row -->

        </div>
        <!-- Footer Links -->
        <!-- Copyright -->
        <div class=""footer-copyright text-center py-3"" style=""background-color:black;color:white;"">
            <p>
                © 2019 Copyright:
                <a href=""#"">acube.com</a></br>
                <a href=""#"">Back to top</a>
            </p>

        <");
                WriteLiteral("/div>\r\n\r\n        <!-- Copyright -->\r\n\r\n    </footer>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7495, 19, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
