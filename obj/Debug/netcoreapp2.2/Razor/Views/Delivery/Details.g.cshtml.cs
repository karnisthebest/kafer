#pragma checksum "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d80df19c51b143424296d34d809eaa50a947d6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_Details), @"mvc.1.0.view", @"/Views/Delivery/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Delivery/Details.cshtml", typeof(AspNetCore.Views_Delivery_Details))]
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
#line 1 "c:\Users\karn_\Documents\kafer\kafer_house\Views\_ViewImports.cshtml"
using kafer_house;

#line default
#line hidden
#line 2 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
using kafer_house.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d80df19c51b143424296d34d809eaa50a947d6f", @"/Views/Delivery/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_Delivery_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kafer_house.Models.Delivery>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary-outlined"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(205, 545, true);
            WriteLiteral(@"



<div class=""bg-body-light"">
    <div class=""content content-full"">
        <div class=""d-flex flex-column flex-sm-row justify-content-sm-between align-items-sm-center"">
            <h1 class=""flex-sm-fill font-size-h2 font-w400 mt-2 mb-0 mb-sm-2"">
                Delivery Detail
            </h1>
        </div>
    </div>
</div>

<div class=""content"">
    <div class=""block block-rounded block-bordered"">
        <div class=""block-header block-header-default"">
            <h3 class=""block-title"">Detail</h3>
            ");
            EndContext();
            BeginContext(750, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d80df19c51b143424296d34d809eaa50a947d6f4581", async() => {
                BeginContext(805, 106, true);
                WriteLiteral("\r\n                    <i class=\"si si-arrow-left\"></i>\r\n                    Back to List\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(915, 254, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"block-content\">\r\n            <dl class=\"row\">\r\n                <dt class = \"col-sm-2\">\r\n                    Id\r\n                </dt>\r\n                <dd id=\"deliveryId\" class = \"col-sm-10\">\r\n                     ");
            EndContext();
            BeginContext(1170, 16, false);
#line 36 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                Write(Model.deliveryId);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 186, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Delivery Date\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1373, 43, false);
#line 42 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
               Write(Model.deliveryDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 181, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Lot Date\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1598, 45, false);
#line 48 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
               Write(Model.productLotDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 186, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Shopping Mall\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1830, 23, false);
#line 54 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
               Write(Model.shoppingmall.name);

#line default
#line hidden
            EndContext();
            BeginContext(1853, 179, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Branch\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2033, 23, false);
#line 60 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
               Write(Model.branch.branchName);

#line default
#line hidden
            EndContext();
            BeginContext(2056, 445, true);
            WriteLiteral(@"
                </dd>

            </dl>

            <div class=""block-content block-content-full"">
                <div class=""table-responsive"">
                    <table id=""dataTable"" class=""table table-hover table-bordered table-striped table-vcenter js-dataTable-full"">
                        <thead>
                            <tr>
                                <td>Product ID</td>
																<td>ProductName</td>
");
            EndContext();
#line 72 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                                                                 if (User.IsInRole(Roles.Manager) || User.IsInRole(Roles.Owner) || User.IsInRole(Roles.Admin))
                                {

#line default
#line hidden
            BeginContext(2648, 35, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>Quantity</td>\r\n");
            EndContext();
#line 75 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
																}

#line default
#line hidden
            BeginContext(2702, 194, true);
            WriteLiteral("                              \r\n                                <td>managerProductQty</td>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 81 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                          
                        double gtotal = 0;
                        foreach(var item in @Model.deliveryItem){
                            double total = item.productPrice*item.productQty;
                            gtotal = gtotal + total;

#line default
#line hidden
            BeginContext(3168, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(3239, 14, false);
#line 87 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                               Write(item.productId);

#line default
#line hidden
            EndContext();
            BeginContext(3253, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3297, 16, false);
#line 88 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                               Write(item.productName);

#line default
#line hidden
            EndContext();
            BeginContext(3313, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3357, 15, false);
#line 89 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                               Write(item.productQty);

#line default
#line hidden
            EndContext();
            BeginContext(3372, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 90 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                                 if (User.IsInRole(Roles.Manager) || User.IsInRole(Roles.Owner))
                                {

#line default
#line hidden
            BeginContext(3512, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(3549, 22, false);
#line 92 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                               Write(item.managerProductQty);

#line default
#line hidden
            EndContext();
            BeginContext(3571, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 93 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                                }

#line default
#line hidden
            BeginContext(3613, 37, true);
            WriteLiteral("\r\n                            </tr>\r\n");
            EndContext();
#line 96 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"

                        }

                        

#line default
#line hidden
            BeginContext(3708, 109, true);
            WriteLiteral("                        </tbody>\r\n\t\t\t\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"row\" style=\"margin-left: 5px;\">\r\n");
            EndContext();
#line 103 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                     if (User.IsInRole(Roles.Manager)|| User.IsInRole(Roles.Owner))
                    {

#line default
#line hidden
            BeginContext(3925, 164, true);
            WriteLiteral("                    <div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<button class=\"btn btn-primary\" id=\"cmd_confirm\">Save</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\r\n                    </div>\r\n");
            EndContext();
#line 109 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
										}

#line default
#line hidden
            BeginContext(4102, 10, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t");
            EndContext();
#line 110 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                                         if (User.IsInRole(Roles.Owner)|| User.IsInRole(Roles.Staff))
                    {

#line default
#line hidden
            BeginContext(4198, 109, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<div style=\"display:flex; flex-direction: row; justify-content: flex-end; align-items: flex-end\">\r\n");
            EndContext();
#line 113 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                                                 if(!String.IsNullOrEmpty(Model.staffName)) {

#line default
#line hidden
            BeginContext(4366, 191, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<button class=\"btn btn-success\" disabled id=\"cmd_confirm_delivered\">Delivered</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div style=\"align-self: center; padding-left: 10px\"><strong>Staff: </strong> ");
            EndContext();
            BeginContext(4558, 15, false);
#line 115 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
                                                                                                                            Write(Model.staffName);

#line default
#line hidden
            EndContext();
            BeginContext(4573, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 116 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
												} else {

#line default
#line hidden
            BeginContext(4603, 99, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<button class=\"btn btn-primary\" id=\"cmd_confirm_delivered\">Confirm Delivery</button>\r\n");
            EndContext();
#line 118 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
												}

#line default
#line hidden
            BeginContext(4717, 32, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n");
            EndContext();
#line 121 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Delivery\Details.cshtml"
										}

#line default
#line hidden
            BeginContext(4762, 101, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4881, 2838, true);
                WriteLiteral(@"
    <script>
		var cmd_confirm = $('#cmd_confirm');
		var cmd_confirm_delivered = $('#cmd_confirm_delivered');
		var deliveryId = $('#deliveryId').text();
    var table;
    var tableData;
    var role;
    $(document).ready( function () {
        $.get(""/delivery/getUserRole"", user_data_arrived);
        cmd_confirm.click(cb_confirm_clicked);
        cmd_confirm_delivered.click(cb_confirm_delivered_clicked);
        table = $('#dataTable').DataTable();
        tableData = table.rows().data().toArray();;
        //  $.get(window.location.pathname, getdeliveryId);

    });

    function user_data_arrived(data) {
        debugger
        console.log(data, 'userdata')
        role = data[0];
        if(role == ""Admin"" || role == ""Owner""){
							table.MakeCellsEditable({
							""onUpdate"": myCallbackFunction,
							""columns"": [2,3],
					});
        }
        if(role == ""Manager""){
					table.MakeCellsEditable({
							""onUpdate"": myCallbackFunction,
							""columns"": [3],
					");
                WriteLiteral(@"});
        }

    }



    function myCallbackFunction(updatedCell, updatedRow, oldValue) {
        // console.log(""The new value for the cell is: "" + updatedCell.data());
        // console.log(""The old value for that cell was: "" + oldValue);
        var updatedRowdata = updatedRow.data();
        // console.log(updatedRowdata);
    }


  function cb_confirm_clicked() {
        console.log(tableData, 'tabledata');
        // const mapped = tableData.map(x => x)
        // console.log(mapped);
        // const tableDatafiltered = tableData.filter(x => x);
        // console.log(tableDatafiltered)

        const deliveryItems = Object.keys(tableData).map(function(key, index) {
            return {
                productId: tableData[key][0],
                productName: tableData[key][1],
                productQty: tableData[key][2],
                managerProductQty: tableData[key][3],
            }

        });
        console.log(deliveryItems, 'deliveryitems')
        
");
                WriteLiteral(@"


        option = {
        data: {
            id: deliveryId,
            items: deliveryItems,
        },
        url: '/delivery/updateCart',
        success: updateCart_done,
        error: function (err) { console.log('error', err); }
        };
        $.post(option);
		}
		
		function cb_confirm_delivered_clicked() {
			debugger
			option = {
        data: {
            id: deliveryId,
	        },
        url: '/delivery/submitDelivered',
        success: reload,
        error: function (err) { console.log('error', err); }
        };
        $.post(option);
		}
		
		function reload() {
			location.reload()
		}

    function updateCart_done(data) {
    window.location.replace(data.newUrl); //redirect to Index Action
  }

    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kafer_house.Models.Delivery> Html { get; private set; }
    }
}
#pragma warning restore 1591
