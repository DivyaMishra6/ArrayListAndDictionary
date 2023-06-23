using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAndDictionary
{
    public class Dictionary
    {
        public void Dict()
        {
            Dictionary<string, Int32> MyDict = new Dictionary<string, Int32>();
            MyDict.Add("Divya", 6);
            MyDict.Add("Shweta", 25);
            MyDict.Add("Madhu", 16);
            MyDict.Add("Gaurav", 30);
            MyDict.Add("Niranjan", 28);


            foreach(KeyValuePair<string, Int32> i in MyDict)
            {
                Console.WriteLine("Key: {0}, Value:{1}", i.Key, i.Value);
            }

            //Count method
            Console.WriteLine("Count {0}", MyDict.Count);

            

            //Remove method
            MyDict.Remove("Niranjan");

            Console.WriteLine("=============================");
            foreach (KeyValuePair<string, Int32> i in MyDict)
            {
                Console.WriteLine("Key: {0}, Value:{1}", i.Key, i.Value);
            }

        }
    }
}
