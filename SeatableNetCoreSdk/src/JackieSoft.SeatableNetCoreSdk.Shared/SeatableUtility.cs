using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace JackieSoft.SeatableNetCoreSdk.Shared
{
    public static class SeatableUtility
    {

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="dictionary">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    sb.Append(iter.Key + "=" + WebUtility.UrlEncode(iter.Value) + "&");
                }
            }

            return sb.ToString()[0..^1];
        }
    }
}
