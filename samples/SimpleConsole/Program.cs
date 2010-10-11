using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Json;

namespace SimpleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonString = "{\"v\":{\"Name\":\"Default\",\"Author\":{\"Name\":\"Jerry\",\"Age\":15},\"Posts\":[{\"Title\":\"Post 1\",\"CreateTime\":\"Fri, 01 Jan 2010 00:00:00 GMT\"},{\"Title\":\"Post 2\",\"CreateTime\":\"Mon, 01 Feb 2010 00:00:00 GMT\"},{\"Title\":\"Post 3\",\"CreateTime\":\"Mon, 01 Mar 2010 00:00:00 GMT\"}]}}";
            var json = JsonValue.Parse(jsonString);
        }
    }
}
