using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Editor
{
    abstract class JSONValue
    {
        // For writing out to a JSON file
        public abstract override string ToString();
        
        // For displaying in a TreeView
        public abstract string Display();
    }

    class JSONPrimitive : JSONValue
    {
        // Meant only for strings, numbers, booleans, and null
        // TODO: separate these out into their own classes someday?
        public object Data { get; set; }

        public JSONPrimitive(object s)
        {
            Data = s;
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

    class JSONObject : JSONValue
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
    
    class JSONArray : JSONValue
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
