using Newtonsoft.Json.Linq;
using System;

namespace TACsharp.Framework.Core.JSON
{
    /// <summary>
    /// JSON Object wrapper class
    /// </summary>
    public class JSONObject
    {
        private JObject _json;

        private JSONObject(JObject json)
        {
            _json = json;
        }

        /// <summary>
        /// Parses JSON string and returns new JSONObject object
        /// </summary>
        public static JSONObject Parse(string json)
        {
            return new JSONObject(JObject.Parse(json));
        }

        /// <summary>
        /// Converts self to a new object of type T and returns the last one
        /// </summary>
        public T ToObject<T>()
        {
            return _json.ToObject<T>();
        }
    }
}
