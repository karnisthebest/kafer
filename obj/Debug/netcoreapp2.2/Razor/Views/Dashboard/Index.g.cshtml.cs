#pragma checksum "C:\Users\karn_\Documents\kafer\kafer_house\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1733df83fd056c76fcb97cbb915bd8b6f5d355ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
#line 1 "C:\Users\karn_\Documents\kafer\kafer_house\Views\_ViewImports.cshtml"
using kafer_house;

#line default
#line hidden
#line 2 "C:\Users\karn_\Documents\kafer\kafer_house\Views\_ViewImports.cshtml"
using kafer_house.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1733df83fd056c76fcb97cbb915bd8b6f5d355ff", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 13956, true);
            WriteLiteral(@"  <!-- Page Content -->
  <div class=""content content-full"">
    <!-- Overview -->
    <div class=""d-flex justify-content-between align-items-center py-3"">
        <h2 class=""h3 font-w400 mb-0"">Overview</h2>
        <div class=""dropdown"">
            <button type=""button"" class=""btn btn-sm btn-light px-3"" id=""dropdown-analytics-overview"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                Last 30 days <i class=""fa fa-fw fa-angle-down""></i>
            </button>
            <div class=""dropdown-menu dropdown-menu-right font-size-sm"" aria-labelledby=""dropdown-analytics-overview"">
                <a class=""dropdown-item"" href=""javascript:void(0)"">This Week</a>
                <a class=""dropdown-item"" href=""javascript:void(0)"">Previous Week</a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""javascript:void(0)"">This Month</a>
                <a class=""dropdown-item"" href=""javascript:void(0)"">Previous Month</a>
      ");
            WriteLiteral(@"      </div>
        </div>
    </div>
    <div class=""row row-deck"">
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"">
            <a class=""block block-rounded block-fx-pop text-center"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""item item-circle bg-primary-lighter mx-auto my-3"">
                        <i class=""fa fa-users text-primary""></i>
                    </div>
                    <div class=""text-black display-4 font-w700"">35.8k</div>
                    <div class=""text-muted mt-1"">Visitors</div>
                    <div class=""py-3 font-size-h4 font-w700 text-success"">
                        <i class=""fa fa-caret-up mr-1""></i>
                        15.7%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""150"">
            <a class=""block block-rounded block-fx-po");
            WriteLiteral(@"p text-center"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""item item-circle bg-xinspire-lighter mx-auto my-3"">
                        <i class=""fa fa-eye text-xinspire-dark""></i>
                    </div>
                    <div class=""text-black display-4 font-w700"">98.5k</div>
                    <div class=""text-muted mt-1"">Page views</div>
                    <div class=""py-3 font-size-h4 font-w700 text-danger"">
                        <i class=""fa fa-caret-down mr-1""></i>
                        2.4%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""300"">
            <a class=""block block-rounded block-fx-pop text-center"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""item item-circle bg-xsmooth-lighter mx-auto my-3"">
 ");
            WriteLiteral(@"                       <i class=""fa fa-columns text-xsmooth""></i>
                    </div>
                    <div class=""text-black display-4 font-w700"">25</div>
                    <div class=""text-muted mt-1"">Pages per visit</div>
                    <div class=""py-3 font-size-h4 font-w700 text-success"">
                        <i class=""fa fa-caret-up mr-1""></i>
                        52.5%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""450"">
            <a class=""block block-rounded block-fx-pop text-center"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""item item-circle bg-xplay-lighter mx-auto my-3"">
                        <i class=""fa fa-level-up-alt text-xplay""></i>
                    </div>
                    <div class=""text-black display-4 font-w700"">12.5%</div>
                    ");
            WriteLiteral(@"<div class=""text-muted mt-1"">Bounce Rate</div>
                    <div class=""py-3 font-size-h4 font-w700 text-danger"">
                        <i class=""fa fa-caret-down mr-1""></i>
                        5.7%
                    </div>
                </div>
            </a>
        </div>
    </div>
    <!-- END Overview -->

    <!-- Visitors Growth -->
    <div class=""d-flex justify-content-between align-items-center pt-5 pb-3"">
        <h2 class=""h3 font-w400 mb-0"">Visitors Growth</h2>
        <div class=""dropdown"">
            <button type=""button"" class=""btn btn-sm btn-light px-3"" id=""dropdown-analytics-visitors-growth"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                This Week <i class=""fa fa-fw fa-angle-down""></i>
            </button>
            <div class=""dropdown-menu dropdown-menu-right font-size-sm"" aria-labelledby=""dropdown-analytics-visitors-growth"">
                <a class=""dropdown-item"" href=""javascript:void(0)"">Last 30 days</a>
   ");
            WriteLiteral(@"             <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""javascript:void(0)"">Previous Week</a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""javascript:void(0)"">This Month</a>
                <a class=""dropdown-item"" href=""javascript:void(0)"">Previous Month</a>
            </div>
        </div>
    </div>
    <div class=""block block-rounded block-fx-pop invisible"" data-toggle=""appear"">
        <div class=""block-content block-content-full"">
            <div class=""row"">
                <div class=""col-md-5 col-lg-4 d-md-flex align-items-md-center"">
                    <div class=""p-md-2 p-lg-3"">
                        <div class=""text-black display-4 font-w700"">3,687</div>
                        <div class=""font-size-lg font-w700"">Your new website visitors</div>
                        <div class=""py-3 d-flex align-items-center"">
                            <div class=""bg-success-lighter px-2 py-1 ro");
            WriteLiteral(@"unded mr-3"">
                                <i class=""fa fa-fw fa-caret-up text-success""></i>
                            </div>
                            <p class=""mb-0"">
                                You have a <span class=""font-w600 text-success"">25% Growth</span> in the last 30 days. Keep it up!
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-7 col-lg-8"">
                    <div class=""p-md-2 p-lg-3"">
                        <!-- Bars Chart Container -->
                        <!-- Chart.js Chart is initialized in js/pages/db_analytics.min.js which was auto compiled from _es6/pages/db_analytics.js -->
                        <!-- For more info and examples you can check out http://www.chartjs.org/docs/ -->
                        <canvas class=""js-chartjs-analytics-bars""></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <");
            WriteLiteral(@"!-- END Visitors Growth -->

    <!-- Quick Statistics -->
    <div class=""d-flex justify-content-between align-items-center pt-5 pb-3"">
        <h2 class=""h3 font-w400 mb-0"">Quick Statistics</h2>
        <div class=""dropdown"">
            <button type=""button"" class=""btn btn-sm btn-light px-3"" id=""dropdown-analytics-quick-stats"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                Last 30 days <i class=""fa fa-fw fa-angle-down""></i>
            </button>
            <div class=""dropdown-menu dropdown-menu-right font-size-sm"" aria-labelledby=""dropdown-analytics-quick-stats"">
                <a class=""dropdown-item"" href=""javascript:void(0)"">This Week</a>
                <a class=""dropdown-item"" href=""javascript:void(0)"">Previous Week</a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""javascript:void(0)"">This Month</a>
                <a class=""dropdown-item"" href=""javascript:void(0)"">Previous Month</a>
           ");
            WriteLiteral(@" </div>
        </div>
    </div>
    <div class=""row row-deck"">
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"">
            <a class=""block block-rounded block-fx-pop"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""font-size-lg font-w700 mb-3"">Followers</div>
                    <div class=""text-black font-size-h1 font-w700"">1,500</div>
                    <div class=""font-size-h4 font-w700 text-success"">
                        <i class=""fa fa-caret-up mr-1""></i>
                        25.6%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""150"">
            <a class=""block block-rounded block-fx-pop"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""font-size-lg font-w700 mb-3"">Comments</div>
            ");
            WriteLiteral(@"        <div class=""text-black font-size-h1 font-w700"">910</div>
                    <div class=""font-size-h4 font-w700 text-success"">
                        <i class=""fa fa-caret-up mr-1""></i>
                        18.6%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""300"">
            <a class=""block block-rounded block-fx-pop"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""font-size-lg font-w700 mb-3"">Downloads</div>
                    <div class=""text-black font-size-h1 font-w700"">57.5k</div>
                    <div class=""font-size-h4 font-w700 text-success"">
                        <i class=""fa fa-caret-up mr-1""></i>
                        14.9%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""a");
            WriteLiteral(@"ppear"" data-timeout=""450"">
            <a class=""block block-rounded block-fx-pop"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""font-size-lg font-w700 mb-3"">Tickets</div>
                    <div class=""text-black font-size-h1 font-w700"">75</div>
                    <div class=""font-size-h4 font-w700 text-danger"">
                        <i class=""fa fa-caret-down mr-1""></i>
                        1.7%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"">
            <a class=""block block-rounded block-fx-pop"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""font-size-lg font-w700 mb-3"">Likes</div>
                    <div class=""text-black font-size-h1 font-w700"">39.6k</div>
                    <div class=""font-size-h4 font-w700 text-success"">
 ");
            WriteLiteral(@"                       <i class=""fa fa-caret-up mr-1""></i>
                        39.8%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""150"">
            <a class=""block block-rounded block-fx-pop"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""font-size-lg font-w700 mb-3"">Errors</div>
                    <div class=""text-black font-size-h1 font-w700"">3</div>
                    <div class=""font-size-h4 font-w700 text-danger"">
                        <i class=""fa fa-caret-down mr-1""></i>
                        25%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""300"">
            <a class=""block block-rounded block-fx-pop"" href=""javascript:void(0)"">
                <div class=""block-");
            WriteLiteral(@"content block-content-full"">
                    <div class=""font-size-lg font-w700 mb-3"">Apps</div>
                    <div class=""text-black font-size-h1 font-w700"">290</div>
                    <div class=""font-size-h4 font-w700 text-success"">
                        <i class=""fa fa-caret-up mr-1""></i>
                        1.2%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""450"">
            <a class=""block block-rounded block-fx-pop"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""font-size-lg font-w700 mb-3"">New Accounts</div>
                    <div class=""text-black font-size-h1 font-w700"">6,300</div>
                    <div class=""font-size-h4 font-w700 text-success"">
                        <i class=""fa fa-caret-up mr-1""></i>
                        3.7%
                    </div>
     ");
            WriteLiteral(@"           </div>
            </a>
        </div>
    </div>
    <!-- END Quick Statistics -->
</div>
<!-- END Page Content -->


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>


<!-- Page JS Plugins -->
 <script src=""assets/js/plugins/easy-pie-chart/jquery.easypiechart.min.js""></script>
 <script src=""assets/js/plugins/chart.js/Chart.bundle.min.js""></script>

 <!-- Page JS Code -->
 <script src=""assets/js/pages/db_analytics.min.js""></script>

 <!-- Page JS Helpers (Easy Pie Chart Plugin) -->
 <!-- <script>jQuery(function(){ Dashmix.helpers('easy-pie-chart'); });</script> -->");
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
