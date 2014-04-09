using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Last.fm.Utils
{
    public class RequestParameters : Dictionary<string, string>
    {
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (string key in Keys)
                sb.Append(key + '=' + HttpUtility.UrlEncode(this[key]) + '&');
            var ret = sb.ToString().Substring(0, sb.Length - 1);
            return ret;
        }

        public byte[] ToBytes()
        {
            return Encoding.UTF8.GetBytes(ToString());
        }

        /// <summary>
        /// RequestParameters constructor.
        /// </summary>
        /// <param name="methodName">Method name to use RequestParameters with</param>
        public RequestParameters(string methodName)
        {
            if (string.IsNullOrEmpty(methodName))
                throw new ArgumentException("Method name cannot be empty", "methodName");
            Add("method", methodName);
        }
    }
}
