using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Editor
{
    public abstract class JSONValue
    {
        // For writing out to a JSON file
        public abstract override string ToString();
        
        // For displaying in a TreeView
        public abstract string Display();
    }

    public class JSONPrimitive : JSONValue
    {
        // Meant only for strings, numbers, booleans, and null
        public object Data { get; set; }

        public enum PrimitiveType
        {
            String,
            Number,
            Boolean,
            Null
        }

        public PrimitiveType Type { get; set; }

        public JSONPrimitive()
        {
            Data = null;
        }

        public override string ToString()
        {
            if(Data is string)
            {
                return "\"" + Data.ToString() + "\"";
            }
            else
            {
                return Data.ToString();
            }
        }

        public override string Display()
        {
            return ToString();
        }
    }

    public class JSONObject : JSONValue
    {
        public Dictionary<string, JSONValue> Data { get; set; }

        public JSONObject()
        {
            Data = new Dictionary<string, JSONValue>();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override string Display()
        {
            return "JSONObject";
        }
    }
    
    public class JSONArray : JSONValue
    {
        public List<JSONValue> Data { get; set; }

        public JSONArray()
        {
            Data = new List<JSONValue>();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override string Display()
        {
            return "JSONArray";
        }
    }
}
