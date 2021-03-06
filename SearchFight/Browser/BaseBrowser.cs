﻿using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Web.Configuration;

namespace Searchfight.Browser
{
    public class BaseBrowser
    {
        private readonly HttpClient _httpClient;
        public BaseBrowser()
        {
            _httpClient = new HttpClient();
        }
        public void AddHeader(string key, string value)
        {
            _httpClient.DefaultRequestHeaders.Add(key, value);
        }
        public JObject GetResponse(string url)
        {
            try
            {
                _httpClient.Timeout = TimeSpan.FromSeconds(3);
                var data = _httpClient.GetStringAsync(url).Result;
                return JObject.Parse(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public string GetSecretKey(string key)
        {
            return WebConfigurationManager.AppSettings[key];
        }
    }
}
