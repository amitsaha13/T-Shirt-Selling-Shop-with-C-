#pragma checksum "G:\CSE 3.2\C# lab\project\T-Shirt\T-Shirt\Views\AdminPanel\InsertProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "453a5425c22b4e98c4e22f90a6e220a792b835ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_InsertProduct), @"mvc.1.0.view", @"/Views/AdminPanel/InsertProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/InsertProduct.cshtml", typeof(AspNetCore.Views_AdminPanel_InsertProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"453a5425c22b4e98c4e22f90a6e220a792b835ab", @"/Views/AdminPanel/InsertProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3196cc98e7db788f1d5150a647d575fdf3c4fcba", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminPanel_InsertProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\CSE 3.2\C# lab\project\T-Shirt\T-Shirt\Views\AdminPanel\InsertProduct.cshtml"
  
    ViewData["Title"] = "InsertProduct";

#line default
#line hidden
            BeginContext(51, 37, true);
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(88, 1281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "453a5425c22b4e98c4e22f90a6e220a792b835ab7041", async() => {
                BeginContext(94, 1268, true);
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
                WriteLiteral("et\" href=\"https://use.fontawesome.com/releases/v5.7.0/css/all.css\" integrity=\"sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ\" crossorigin=\"anonymous\">\r\n    \r\n    <!------ Include the above in your HEAD tag ---------->\r\n");
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
            BeginContext(1369, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1373, 10106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "453a5425c22b4e98c4e22f90a6e220a792b835ab9578", async() => {
                BeginContext(1379, 72, true);
                WriteLiteral("\r\n\r\n\r\n    <div class=\"container text-right\"  >\r\n        \r\n\r\n            ");
                EndContext();
                BeginContext(1451, 5476, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "453a5425c22b4e98c4e22f90a6e220a792b835ab10046", async() => {
                    BeginContext(1572, 507, true);
                    WriteLiteral(@"
                
                    <div class=""form-group"">
                        <div class=""row"" style=""padding-bottom:1%;"">
                            <div class=""col-md-3"">
                                <label class=""font-weight-bold text-left"">Product Catagory</label>
                            </div>
                            <div class=""col-md-7 align-self-end "">
                                <select class=""form-control"" name=""catagory"">
                                    ");
                    EndContext();
                    BeginContext(2079, 20, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "453a5425c22b4e98c4e22f90a6e220a792b835ab10972", async() => {
                        BeginContext(2087, 3, true);
                        WriteLiteral("MEN");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2099, 38, true);
                    WriteLiteral("\r\n                                    ");
                    EndContext();
                    BeginContext(2137, 22, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "453a5425c22b4e98c4e22f90a6e220a792b835ab12342", async() => {
                        BeginContext(2145, 5, true);
                        WriteLiteral("WOMEN");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2159, 38, true);
                    WriteLiteral("\r\n                                    ");
                    EndContext();
                    BeginContext(2197, 21, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "453a5425c22b4e98c4e22f90a6e220a792b835ab13714", async() => {
                        BeginContext(2205, 4, true);
                        WriteLiteral("KIDS");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2218, 4702, true);
                    WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""row"" style=""padding-bottom:1%;"">
                            <div class=""col-md-3"">
                                <label class=""font-weight-bold text-left"">Product Sub Catagory</label>
                            </div>
                            <div class=""col-md-7"">
                                <input name=""productid"" type=""text"" class=""form-control"" id="""" placeholder=""Enter sub catagory"">
                            </div>
                        </div>
                        <div class=""row"" style=""padding-bottom:1%;"">
                            <div class=""col-md-3"">
                                <label class=""font-weight-bold"">Product Name</label>
                            </div>
                            <div class=""col-md-7"">
                                <input name=""productname"" type=""text"" class=""form-control"" id=""name"" pl");
                    WriteLiteral(@"aceholder=""Enter product name"">

                            </div>
                        </div>
                        <div class=""row"" style=""padding-bottom:1%;"">
                            <div class=""col-md-3"">
                                <label class=""font-weight-bold"">Product Details</label>
                            </div>
                            <div class=""col-md-7"">
                                <textarea name=""productdetails"" type=""text"" class=""form-control md-textarea"" rows=""3"" placeholder=""Enter product Details""></textarea>
                            </div>
                        </div>
                        <div class=""row"" style=""padding-bottom:1%;"">
                            <div class=""col-md-3"">
                                <label class=""font-weight-bold"" style=""padding-right:2%;"">Available Color</label>
                            </div>
                            <div class=""col-md-7"">
                                <input name=""color"" type=""text");
                    WriteLiteral(@""" class=""form-control"" id=""name"" placeholder=""Enter colors name eg: black,blue etc"">
                            </div>
                        </div>
                        <div class=""row"" style=""padding-bottom:1%;"">
                            <div class=""col-md-3"">
                                <label class=""font-weight-bold"">Available Quantity</label>
                            </div>
                            <div class=""col-md-7"">
                                <input name=""quantity"" type=""text"" class=""form-control"" id="""" placeholder=""Enter product quantity"">
                            </div>
                        </div>
                        <div class=""row"" style=""padding-bottom:1%;"">
                            <div class=""col-md-3"">
                                <label class=""font-weight-bold"">Discount if available</label>
                            </div>
                            <div class=""col-md-7"">
                                <input name=""discount"" type=""t");
                    WriteLiteral(@"ext"" class=""form-control"" id="""" placeholder=""Enter product discount in %"">
                            </div>
                        </div>
                        <div class=""row"" style=""padding-bottom:1%;"">
                            <div class=""col-md-3"">
                                <label class=""font-weight-bold"">Product Price</label>
                            </div>
                            <div class=""col-md-7"">
                                <input name=""price"" type=""text"" class=""form-control"" id="""" placeholder=""Enter product price"">
                            </div>
                        </div>
                        <div class=""row"" style=""padding-bottom:1%;"">
                            <div class=""col-md-3"">
                                <label><strong>Upload Product Image</strong></label>
                            </div>
                            <div class=""col-md-7"">
                                <input name=""image"" type=""file"" class=""form-control-file"" id");
                    WriteLiteral(@"=""exampleFormControlFile1"">
                            </div>
                        </div>

                        <div class=""row"" style=""padding-bottom:1%;"">
                            <div class=""col-md-10"">
                                <div class=""modal-footer border-top-0 d-flex justify-content-center"">
                                    <button type=""submit"" name=""insert"" class=""btn btn-dark btn-lg btn-block"">Insert Product</button>
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
                BeginContext(6927, 547, true);
                WriteLiteral(@"
        </div>


    
    <footer class=""page-footer font-small unique-color-dark"">



        <!-- Footer Links -->
        <div class=""container text-center text-md-left mt-5"" style=""background-color: black; color:white;"">

            <!-- Grid row -->
            <div class=""row mt-3"">

                <!-- Grid column -->
                <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"" style=""padding-top:25px;"">

                    <!-- Content -->
                    <h6 class=""text-uppercase font-weight-bold"">");
                EndContext();
                BeginContext(7474, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "453a5425c22b4e98c4e22f90a6e220a792b835ab22244", async() => {
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
                BeginContext(7554, 3918, true);
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
            <div class=""row"">
                <div class=""col-md-12 text-center py-3"" style=""color:white;"">
                    <p>
                        ?? 2019 Copyright:
                        <a href=""#"">ajstore.com</a></br>
                        <a href=""#"">Back to top</a>
                    </p>

                </div>

         ");
                WriteLiteral(@"   </div>

        </div>




        <!-- Copyright -->

    </footer>
    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script>window.jQuery || document.write('<script src=""../../assets/js/vendor/jquery-slim.min.js""><\/script>')</script>
    <script src=""../../assets/js/vendor/popper.min.js""></script>
    <script src=""../../dist/js/bootstrap.min.js""></script>
    <!-- Just to make our placeholder images work. Don't actually copy the next line! -->
    <script src=""../../assets/js/vendor/holder.min.js""></script>

");
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
            BeginContext(11479, 21, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n</html>\r\n");
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
