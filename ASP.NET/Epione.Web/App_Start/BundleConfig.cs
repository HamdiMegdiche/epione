﻿using System.Web;
using System.Web.Optimization;

namespace Epione.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new StyleBundle("~/Content/chat").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/Chat/emoji.css.map",
                    "~/Content/Chat/emoji.css",
                    "~/Content/Chat/ChatStyle.css"));
            bundles.Add(new ScriptBundle("~/Scripts/chat").Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/Chat/config.js",
                    "~/Scripts/Chat/util.js",
                    "~/Scripts/Chat/jquery.emojiarea.js",
                    "~/Scripts/Chat/emoji-picker.js",
                    "~/Scripts/Chat/emoji-picker.coffee",
                     "~/Scripts/Chat/emoji-picker.js.map",
                    "~/Scripts/Chat/ChatScript.js"));
        }
    }
}
