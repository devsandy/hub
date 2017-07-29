using System.Web.Optimization;
namespace Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles ) {

            #region Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-{version}.js"));
            #endregion

            #region Styles
            bundles.Add(new LessBundle("~/Content/css").Include("~/Content/bootstrap/bootstrap.less"));
            #endregion
        }
    }
}