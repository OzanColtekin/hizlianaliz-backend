using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Timers;
using System.Web;

namespace UIProject.Models.API
{
    public class TrendyolAPI
    {
        readonly Context _context = new();
        public int GetProduct(int UserID)
        {
            var kisi = _context.UserAPIs.Where(x => x.UserID == UserID && x.MarketID == 1).FirstOrDefault();
            if (kisi == null) return 0;
            var url = "https://api.trendyol.com/sapigw/suppliers/" + kisi.SellerID + "/products?page=0&size=50&approved=True";
            var encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{kisi.ApiKey}:{kisi.ApiSecret}"));

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Headers["Authorization"] = "Basic " + encoded;
            httpRequest.Headers["name"] = kisi.SellerID + " - Trendyol";

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            if (httpResponse.StatusDescription != "OK") return 0;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                JObject json = JObject.Parse(result);
                foreach (var e in json.SelectToken("content"))
                {
                    UserProducts prd = new()
                    {
                        UserID = UserID,
                        Stock = Convert.ToInt32(e["quantity"]),
                        Barcode = e["barcode"].ToString(),
                        Brand = e["brand"].ToString(),
                        SalePrice = Convert.ToDecimal(e["salePrice"]),
                        Title = e["title"].ToString(),
                        ListPrice = Convert.ToDecimal(e["listPrice"]),
                        CategoryName = e["categoryName"].ToString(),
                        Description = e["description"].ToString(),
                        ImgURL = e["images"][0]["url"].ToString()
                    };
                    if (_context.UserProducts.FirstOrDefault(x => x.Barcode == prd.Barcode) == null)
                    {
                        _context.UserProducts.Add(prd);
                        _context.SaveChanges();
                    }
                    else
                    {
                        var prdct = _context.UserProducts.FirstOrDefault(x => x.Barcode == prd.Barcode);
                        prdct.UserID = UserID;
                        prdct.Stock = Convert.ToInt32(e["quantity"]);
                        prdct.Barcode = e["barcode"].ToString();
                        prdct.Brand = e["brand"].ToString();
                        prdct.SalePrice = Convert.ToDecimal(e["salePrice"]);
                        prdct.Title = e["title"].ToString();
                        prdct.ListPrice = Convert.ToDecimal(e["listPrice"]);
                        prdct.CategoryName = e["categoryName"].ToString();
                        prdct.Description = e["description"].ToString();
                        prdct.ImgURL = e["images"][0]["url"].ToString();
                        _context.SaveChanges();
                    }
                }
            }
            return 1;
        }
        public void UpdateStockandPrice(UserProducts userProducts)
        {
            var kisi = _context.UserAPIs.FirstOrDefault(x => x.UserID == userProducts.UserID);
            var url = "https://api.trendyol.com/sapigw/suppliers/" + kisi.SellerID + "/products/price-and-inventory";
            var encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{kisi.ApiKey}:{kisi.ApiSecret}"));

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Headers["Authorization"] = "Basic " + encoded;
            httpRequest.Headers["name"] = kisi.SellerID + " - Trendyol";
            httpRequest.ContentType = "application/json";


            var data = @"{
              ""items"": [
                {
                  ""barcode"": " + userProducts.Barcode.ToString() + @",
                  ""quantity"": " + Convert.ToInt32(userProducts.Stock) + @",
                  ""salePrice"": " + Convert.ToInt32(userProducts.SalePrice) + @",
                  ""listPrice"": " + Convert.ToInt32(userProducts.ListPrice) + @"
                }
              ]
            }";


            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using var streamReader = new StreamReader(httpResponse.GetResponseStream());
            var result = streamReader.ReadToEnd();

        }

        public void GetShipmentPackges(int UserID)
        {
            var kisi = _context.UserAPIs.Where(x => x.UserID == UserID && x.MarketID == 1).FirstOrDefault();
            var url = "https://api.trendyol.com/sapigw/suppliers/" + kisi.SellerID + "/orders";
            var encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{kisi.ApiKey}:{kisi.ApiSecret}"));

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Headers["Authorization"] = "Basic " + encoded;
            httpRequest.Headers["name"] = kisi.SellerID + " - Trendyol";

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) {
                var result = streamReader.ReadToEnd();
                JObject json = JObject.Parse(result);
                foreach(var e in json.SelectToken("content"))
                {
                    //burayı doldurcam
                }
            }
        }

    }
}
