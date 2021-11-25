using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLogic
{

    public class FizzBuzzClass
    {
        public string PrintNums(int val)
        {
            string ans="";
            for (int i = 1; i <= val; i++)
            {
                ans+= Validate(i)+",";
            }
            return ans;
        }

       public string Validate(int num)
        {
            int both = 0;
            string ret = "";
            if(num%3 ==0)
            {
                ret=  "Fizz";
                both++;
            }
            if (num % 5 == 0)
            {
                ret= "Buzz";
                both++;
            }
            if (num.ToString().IndexOf("5") > 0)
            {
                ret = "Buzz"; 
            }
            if(num.ToString().IndexOf("3") > 0)
            {
                ret = "Fizz";
            }
            if(both==2)
            {
                ret = "FizzBuzz";
            }
            if(both==0)
            {
                ret = num.ToString();
            }
            return ret;
        }        
    }
}
