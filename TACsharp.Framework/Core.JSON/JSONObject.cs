using Newtonsoft.Json.Linq;

namespace TACsharp.Framework.Core.JSON
{
    public class JSONObject
    {
        private JObject _json;

        private JSONObject(JObject json)
        {
            _json = json;
        }

        public static JSONObject Parse(string json)
        {
            return new JSONObject(JObject.Parse(json));
        }

        public T ToObject<T>()
        {
            return _json.ToObject<T>();
        }

    }
}
