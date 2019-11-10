using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectHelper
{
    public abstract class AbstractSpecClasses
    {
        protected Dictionary<string, object> dict;
        public AbstractSpecClasses()
        {
            dict = new Dictionary<string, object>();
            dict.Add("stringABC", "abc");
            dict.Add("value", 4);
        }

        public object Item(string itemName) => dict.FirstOrDefault(it=>it.Key == itemName).Value ?? null;
    }

    public class TestAnstract : AbstractSpecClasses
    {
        public TestAnstract() : base()
        {
            dict.Add("spec", 1.1);
        }
    }

}