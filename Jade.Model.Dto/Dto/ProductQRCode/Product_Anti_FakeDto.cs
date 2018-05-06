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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jade.Model.Dto
{
    public class Product_Anti_FakeDto
    {
        public int id { get; set; }
        public string product_thumb_pic { get; set; }
        public string product_pictures { get; set; }
        public string product_name { get; set; }
        public string product_code { get; set; }
        public string product_summary { get; set; }
        public int product_star_white { get; set; }
        public int product_star_granularity { get; set; }
        public int product_star_defect { get; set; }
        public int product_star_oily { get; set; }
        public Nullable<int> product_id { get; set; }
        public int status { get; set; }
        public System.DateTime create_time { get; set; }
        public string product_qrcode_path { get; set; }
    }
}
