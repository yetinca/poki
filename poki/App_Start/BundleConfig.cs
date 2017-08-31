using System.Web.Optimization;

namespace poki
{
  public class BundleConfig
  {
    // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/jquery-3.1.1.js",
                  "~/Scripts/jquery-ui-1.12.1.js",
                   "~/Scripts/jquery.validate.js",
                   "~/Scripts/fileinput.min.js",
                  "~/Scripts/jquery.validate.unobtrusive.js",
                   "~/Scripts/bootstrap.js",

                    "~/Scripts/Functions.js"

                  ));

      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(

                "~/Scripts/respond.js"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/themes/base/jquery-ui.css",
                "~/Content/site.css"));

      bundles.Add(new ScriptBundle("~/bundles/Testy").Include(
            "~/Scripts/Slider.js"
            ));

      bundles.Add(new ScriptBundle("~/bundles/Participants").Include(
      "~/Scripts/LoadPicture.js"
      ));
      bundles.Add(new ScriptBundle("~/bundles/AvailableParticipants").Include(
      "~/Scripts/AvailableParticipants.js"
      ));
      bundles.Add(new ScriptBundle("~/bundles/GroupWithDetails").Include("~/Scripts/modal.js"));
      bundles.Add(new ScriptBundle("~/bundles/Charts").Include(
        "~/Scripts/chart.js",
        "~/Scripts/GroupStats.js"
                   ));
    }
  }
}
