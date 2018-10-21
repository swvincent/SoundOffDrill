# region LICENSE
///////////////////////////////////////////////////////////////////////////////
// MIT License
//
// Copyright 2018 Scott W. Vincent
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
///////////////////////////////////////////////////////////////////////////////
#endregion LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoundOffDrill.Biz;

namespace SoundOffDrill.Data
{
    public class JsonMapper
    {
        private JObject data;

        /// <summary>
        /// Create new JSON mapper
        /// </summary>
        /// <param name="fileName">JSON file to open</param>
        public JsonMapper(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                string json = reader.ReadToEnd();
                data = JObject.Parse(json);
            }
        }

        /// <summary>
        /// Retrieve List of objects from JSON file.
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="key">key</param>
        /// <returns>List of objects of specified type</returns>
        public List<T> RetrieveList<T>(string key)
        {
            List<T> t;

            // Figured this out from
            // https://www.newtonsoft.com/json/help/html/ToObjectComplex.htm
            JArray a = (JArray)data[key];
            if (a != null)
                t = a.ToObject<List<T>>();
            else
                throw new JsonSerializationException(
                    $"No JSON array was found with key \"{key}\".");

            return t;
        }
    }
}
