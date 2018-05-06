﻿/*
********************************************************************
*
*    曹旭升（sheng.c）
*    E-mail: cao.silhouette@msn.com
*    QQ: 279060597
*    https://github.com/iccb1013
*    http://shengxunwei.com r
*

*
********************************************************************/


using System.Web;
using System.Web.Optimization;

namespace Jade.Shell
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            //// 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
            "~/Scripts/common.js",
            "~/Scripts/dictionaryItems.js",
            "~/Scripts/enums.js"));

            bundles.Add(new ScriptBundle("~/bundles/md5").Include(
              "~/Scripts/MD5.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/Layout.css",
                      "~/Content/Style.css",
                      "~/Content/Font.css",
                      "~/Content/Input.css",
                      "~/Content/A.css",
                      "~/Content/Tab.css",
                      "~/Content/font-awesome.min.css"));
        }
    }
}
