using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRecipient
{
    public class Solution
    {
        public string GetRecipient(string message, int position)
        {
            // Your code goes here
            if (message.Length == 0) return "";
            if (position <= 0) return "";
            var resultList = new List<string>();
            List<String> messageElements = message.Split(" ").ToList();
            string resultstr = ""; 
            foreach (String element in messageElements)
            {
                if (element.StartsWith("@"))
                {
                    resultstr = "";
                    foreach (char c in element)
                    {
                        if (char.IsLetter(c) || char.IsDigit(c) || c == '_' || c=='-')
                        {
                            resultstr += c;
                        }
                    }
                    resultList.Add(resultstr);
                }
            }
            if (resultList.Count <= position - 1) return "";
            return resultList[position - 1];
        }
    }
}
