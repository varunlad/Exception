using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeException
{
    public class ExceptionMood
    {
        public string message;

        public ExceptionMood(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {

                if (message.ToLower().Contains("happy"))//Condition to check if my Message contain Happy Word or Not
                {
                    return "happy";
                }
                else if (message.ToLower().Contains("sad"))//Condition to check if my Message contain Happy Word or Not
                {
                    return "sad";
                }
                else
                {
                    return "Nither Happy nor Sad";
                }
            }
            catch(NullReferenceException)
            {
                return "happy";
            }
        }
    }
}

