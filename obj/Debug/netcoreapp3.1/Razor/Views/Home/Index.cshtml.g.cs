#pragma checksum "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb0a8f289b3dd882ba9684d0f4868befe30636e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\_ViewImports.cshtml"
using _8DSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\_ViewImports.cshtml"
using _8DSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\_ViewImports.cshtml"
using _8DSystem.Models.Views;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0a8f289b3dd882ba9684d0f4868befe30636e9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8a17ad580bc117807f39af7947bd490c0ad35b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout4.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header bg-dark py-0"">
        <h5 class=""card-title text-white"" style=""margin-bottom:5px;margin-top:5px""> Reports</h5>
    </div>
    <div class=""card-body"">
        <div class=""col-12 table-responsive"" id=""bindTableHistory"">
            <div class=""spinner-border text-primary mr-2"" role=""status"">
                <span class=""sr-only"">Loading...</span>
            </div> Loading....
        </div>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            const bindData = () => {\r\n                var getUrl = `");
#nullable restore
#line 24 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\Home\Index.cshtml"
                         Write(Url.Action("Detail","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;

                $(""#bindTableHistory"").load(getUrl,
                    function (statusTxt) {
                        if (statusTxt == ""error"") {
                            alert(""Error occured durring process. Please contact administrator"")
                        }
                        var table = $(""#historyTable"").DataTable({
                            ""order"": [[1, ""asc""]],
                            ""pageLength"": 50,
                            ""orderCellsTop"": true,
                            ""fixedHeader"": true,
                            //initComplete: function () {
                            //var api = this.api();
                            //    $('.filterhead', api.table().header()).each(function (i) {
                            //        var title = $(this).text();
                            //        var column = api.column(i);

                            //        if (title === 'Status') {
                            //            var select = $('<select s");
                WriteLiteral(@"tyle=""width: 100px;""><option value="""" >Search ' + title + '</option></select>')
                            //                .appendTo($(this).empty())
                            //                .on('change', function () {
                            //                    var val = $.fn.dataTable.util.escapeRegex(
                            //                        $(this).val()
                            //                    );
                            //                    column
                            //                        .search(val ? '^' + val + '$' : '', true, false)
                            //                        .draw();
                            //                });
                            //            select.append('<option value=""' + 'Draft' + '"">' + 'Draft' + '</option>');
                            //            select.append('<option value=""' + 'Auditee Assign' + '"">' + 'Auditee Assign' + '</option>');
                            //            sele");
                WriteLiteral(@"ct.append('<option value=""' + 'Auditor Verify' + '"">' + 'Auditor Verify' + '</option>');
                            //            select.append('<option value=""' + 'HSE Verify' + '"">' + 'HSE Verify' + '</option>');
                            //            select.append('<option value=""' + 'HSE Mgr Verify' + '"">' + 'HSE Mgr Verify' + '</option>');
                            //            select.append('<option value=""' + 'Process Task' + '"">' + 'Process Task' + '</option>');
                            //            select.append('<option value=""' + 'Auditor Verify Task' + '"">' + 'Auditor Verify Task' + '</option>');
                            //            select.append('<option value=""' + 'HSE Verify Task' + '"">' + 'HSE Verify Task' + '</option>');
                            //            select.append('<option value=""' + 'HSE Mgr Verify Task' + '"">' + 'HSE Mgr Verify Task' + '</option>');
                            //            select.append('<option value=""' + 'QA Verify' + '"">' + 'QA Verify'");
                WriteLiteral(@" + '</option>');
                            //            select.append('<option value=""' + 'QA Mgr Verify' + '"">' + 'QA Mgr Verify' + '</option>');
                            //            select.append('<option value=""' + 'QA Verify Task' + '"">' + 'QA Verify Task' + '</option>');
                            //            select.append('<option value=""' + 'QA Mgr Verify Task' + '"">' + 'QA Mgr Verify Task' + '</option>');
                            //            select.append('<option value=""' + 'Cancel' + '"">' + 'Cancel' + '</option>');
                            //            select.append('<option value=""' + 'Closed' + '"">' + 'Closed' + '</option>');
                            //        }
                            //        else if (title === 'Report No.') {
                            //            $(this).html('<input type=""text"" placeholder=""Search ' + title + '"" />');
                            //            $('input', this).on('keyup change', function () {
                           ");
                WriteLiteral(@" //                if (table.column(i).search() !== this.value) {
                            //                    table
                            //                        .column(i)
                            //                        .search(this.value)
                            //                        .draw();
                            //                }
                            //            });
                            //        }
                            //        else if (title === 'Subject') {
                            //            $(this).html('<input type=""text"" placeholder=""Search ' + title + '"" />');
                            //            $('input', this).on('keyup change', function () {
                            //                if (table.column(i).search() !== this.value) {
                            //                    table
                            //                        .column(i)
                            //                        .searc");
                WriteLiteral(@"h(this.value)
                            //                        .draw();
                            //                }
                            //            });
                            //        }
                            //        else if (title === 'Register By') {
                            //            $(this).html('<input type=""text"" placeholder=""Search ' + title + '"" />');
                            //            $('input', this).on('keyup change', function () {
                            //                if (table.column(i).search() !== this.value) {
                            //                    table
                            //                        .column(i)
                            //                        .search(this.value)
                            //                        .draw();
                            //                }
                            //            });
                            //        }
                            //");
                WriteLiteral(@"        else if (title === 'Register Date') {
                            //            $(this).html('<input type=""text"" placeholder=""Search ' + title + '"" />');
                            //            $('input', this).on('keyup change', function () {
                            //                if (table.column(i).search() !== this.value) {
                            //                    table
                            //                        .column(i)
                            //                        .search(this.value)
                            //                        .draw();
                            //                }
                            //            });
                            //        }
                            //        else if (title === 'Auditor Name') {
                            //            $(this).html('<input type=""text"" placeholder=""Search ' + title + '"" />');
                            //            $('input', this).on('keyup change', fun");
                WriteLiteral(@"ction () {
                            //                if (table.column(i).search() !== this.value) {
                            //                    table
                            //                        .column(i)
                            //                        .search(this.value)
                            //                        .draw();
                            //                }
                            //            });
                            //        }
                            //        else if (title === 'Auditee Name') {
                            //            $(this).html('<input type=""text"" placeholder=""Search ' + title + '"" />');
                            //            $('input', this).on('keyup change', function () {
                            //                if (table.column(i).search() !== this.value) {
                            //                    table
                            //                        .column(i)
                ");
                WriteLiteral(@"            //                        .search(this.value)
                            //                        .draw();
                            //                }
                            //            });
                            //        }
                            //        else if (title === 'Action Task Owner') {
                            //            $(this).html('<input type=""text"" placeholder=""Search ' + title + '"" />');
                            //            $('input', this).on('keyup change', function () {
                            //                if (table.column(i).search() !== this.value) {
                            //                    table
                            //                        .column(i)
                            //                        .search(this.value)
                            //                        .draw();
                            //                }
                            //            });
                     ");
                WriteLiteral(@"       //        }
                            //        else {
                            //            var select = $('<select><option value="""">Search ' + title + '</option></select>')
                            //                .appendTo($(this).empty())
                            //                .on('change', function () {
                            //                    var val = $.fn.dataTable.util.escapeRegex(
                            //                        $(this).val()
                            //                    );
                            //                    column
                            //                        .search(val ? '^' + val + '$' : '', true, false)
                            //                        .draw();
                            //                });
                            //            column.data().unique().sort().each(function (e, j) {
                            //                select.append('<option value=""' + e + '"">' + e +");
                WriteLiteral(@" '</option>');
                            //            });
                            //        }
                            //});
                            //}
                        });
                    }
                );
            }

            bindData();

        });
    </script>
");
            }
            );
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
