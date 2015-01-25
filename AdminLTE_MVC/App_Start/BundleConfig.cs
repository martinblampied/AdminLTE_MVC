using System.Web;
using System.Web.Optimization;

namespace AdminLTE_MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-1.10.4.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/AdminLTE", "http://cdnjs.cloudflare.com/ajax/libs/raphael/2.1.0/raphael-min.js").Include(
    "~/Content/AdminLTE/js/plugins/morris/morris.min.js",
    "~/Content/AdminLTE/js/plugins/sparkline/jquery.sparkline.min.js",
    "~/Content/AdminLTE/js/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
    "~/Content/AdminLTE/js/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
    "~/Content/AdminLTE/js/plugins/fullcalendar/fullcalendar.min.js",
    "~/Content/AdminLTE/js/plugins/jqueryKnob/jquery.knob.js",
    "~/Content/AdminLTE/js/plugins/daterangepicker/daterangepicker.js",
    "~/Content/AdminLTE/js/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
    "~/Content/AdminLTE/js/plugins/iCheck/icheck.min.js",
    "~/Content/AdminLTE/js/AdminLTE/app.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
    "~/Content/AdminLTE/css/font-awesome.min.css",
     "~/Content/AdminLTE/css/ionicons.min.css",
    "~/Content/AdminLTE/css/morris/morris.css",
     "~/Content/AdminLTE/css/jvectormap/jquery-jvectormap-1.2.2.css",
     "~/Content/AdminLTE/css/fullcalendar/fullcalendar.css",
     "~/Content/AdminLTE/css/daterangepicker/daterangepicker-bs3.css",
     "~/Content/AdminLTE/css/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
      "~/Content/AdminLTE/css/AdminLTE.css"));


            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;

        }
    }
}
