#pragma checksum "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983fe00cff666a20c567f0097c4a8cd1b012bf7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateCustomer), @"mvc.1.0.view", @"/Views/Home/UpdateCustomer.cshtml")]
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
#line 1 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Customer_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Customer_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983fe00cff666a20c567f0097c4a8cd1b012bf7a", @"/Views/Home/UpdateCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c20769abb6fabd1e65d89915a1feee54dcd53e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UpdateCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return updateCustomer();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("customerForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml"
  
    ViewData["Title"] = "Update Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983fe00cff666a20c567f0097c4a8cd1b012bf7a5086", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Customer Form</h1>
    <p></p>
</div>
<script>
    function updateCustomer() {
        var data = JSON.stringify ({
            compagny_name: $('#compagny_name').val(),
            full_name_of_the_compagny_contact: $('#full_name_of_the_company_contact').val(),
            company_contact_phone: $('#company_contact_phone').val(),
            full_name_of_service_technical_authority: $('#full_name_of_service_technical_authority').val(),
            technical_authority_phone_for_service: $('#technical_authority_phone_for_service').val(),
            technical_manager_email_for_service: $('#technical_manager_email_for_service').val(),
            company_description: $('#company_description').val(),
            email_of_the_company_contact: $('#email_of_the_company_contact').val()
        });
        $.ajax({
            //url: 'http://localhost:5000/api/Customers',
            url: 'https://rocket-elevators-rest-api-code.herokuapp.com/api/");
            WriteLiteral(@"Customers/',
            type: 'PUT',
            data: data,
            headers: {
                'Content-Type': 'application/json' 
            },
            success: function (result) {
                alert('Customer updated successfully!');
                return false;
            }
        });
        return false;
    }
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983fe00cff666a20c567f0097c4a8cd1b012bf7a7542", async() => {
                WriteLiteral(@"
    <div id=""quote_form"" class=""container"">
        <div class=""row"">
            <div id=""typeChoice"" class=""col-md-12 form-group"">

                <!-- ************************************* USE OF JAVASCRIPT FOR THE DYNAMIC DROPDOWNS ************************************* -->
                <script>
                    let customer = JSON.parse('");
#nullable restore
#line 46 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml"
                                          Write(Html.Raw(Json.Serialize(ViewBag.customer)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
                </script>


                <!-- *********************************************** INPUT TEXTS *********************************************** -->
                <!-- ------------ Company Name --------------------------------------------------------------------------- -->
                <label for=""compagny_name"">Company Name</label>
                <input required type=""text""");
                BeginWriteAttribute("value", " value=\"", 2363, "\"", 2402, 1);
#nullable restore
#line 53 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml"
WriteAttributeValue("", 2371, ViewBag.customer.compagny_name, 2371, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" name=""compagny_name"" id=""compagny_name"">
                <br />

                <!-- ------------ Company Contact Name --------------------------------------------------------------------------- -->
                <label for=""full_name_of_the_compagny_contact"">Company Contact Name</label>
                <input required type=""text""");
                BeginWriteAttribute("value", " value=\"", 2765, "\"", 2823, 1);
#nullable restore
#line 58 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml"
WriteAttributeValue("", 2773, ViewBag.customer.full_name_of_the_company_contact, 2773, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" name=""full_name_of_the_company_contact"" id=""full_name_of_the_company_contact"">
                <br />

                <!-- ------------ Company Contact Phone --------------------------------------------------------------------------- -->
                <label for=""company_contact_phone"">Company Contact Phone</label>
                <input required type=""text""");
                BeginWriteAttribute("value", " value=\"", 3214, "\"", 3261, 1);
#nullable restore
#line 63 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml"
WriteAttributeValue("", 3222, ViewBag.customer.company_contact_phone, 3222, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" name=""company_contact_phone"" id=""company_contact_phone"">
                <br />

                <!-- ------------ Support Contact Name --------------------------------------------------------------------------- -->
                <label for=""full_name_of_service_technical_authority"">Support Contact Name</label>
                <input required type=""text""");
                BeginWriteAttribute("value", " value=\"", 3647, "\"", 3713, 1);
#nullable restore
#line 68 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml"
WriteAttributeValue("", 3655, ViewBag.customer.full_name_of_service_technical_authority, 3655, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" name=""full_name_of_service_technical_authority"" id=""technical_authority_phone_for_service"">
                <br />

                <!-- ------------ Support Contact Phone --------------------------------------------------------------------------- -->
                <label for=""technical_authority_phone_for_service"">Technical Support Contact Phone</label>
                <input required type=""text""");
                BeginWriteAttribute("value", " value=\"", 4143, "\"", 4206, 1);
#nullable restore
#line 73 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml"
WriteAttributeValue("", 4151, ViewBag.customer.technical_authority_phone_for_service, 4151, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" name=""technical_authority_phone_for_service"" id=""technical_authority_phone_for_service"">
                <br />

                <!-- ------------ Support Contact Email --------------------------------------------------------------------------- -->
                <label for=""technical_manager_email_for_service"">Support Contact Email</label>
                <input required type=""text""");
                BeginWriteAttribute("value", " value=\"", 4621, "\"", 4682, 1);
#nullable restore
#line 78 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml"
WriteAttributeValue("", 4629, ViewBag.customer.technical_manager_email_for_service, 4629, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" name=""technical_manager_email_for_service"" id=""technical_manager_email_for_service"">
                <br />

                <!-- ------------ Company Description --------------------------------------------------------------------------- -->
                <label for=""company_description"">Company Description</label>
                <input required type=""text""");
                BeginWriteAttribute("value", " value=\"", 5073, "\"", 5118, 1);
#nullable restore
#line 83 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml"
WriteAttributeValue("", 5081, ViewBag.customer.company_description, 5081, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" name=\"company_description\" id=\"company_description\">\r\n                <br />\r\n\r\n                <input hidden type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 5262, "\"", 5316, 1);
#nullable restore
#line 86 "C:\Users\Hakim\Desktop\alex\Rocket_Elevators_Customer_Portal\Views\Home\UpdateCustomer.cshtml"
WriteAttributeValue("", 5270, ViewBag.customer.email_of_the_company_contact, 5270, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""email_of_the_company_contact"" id=""email_of_the_company_contact"">


                <div class=""row"">
                    <!--submit-->
                    <div class=""col-md-12"">
                        <button type=""submit"" class=""btn btn-primary"" id=""btnIntervention""><i class=""fa fa-check""></i> SUBMIT</button>
                        <br /><br />
                    </div>
                </div>
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