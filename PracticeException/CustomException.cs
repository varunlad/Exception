using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeException
{
    public class CustomException :Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            EMPTY_TYPE_EXCEPTION,
            INVALID_MOOD_EXCEPTION,
        }
        public CustomException(ExceptionType type, string massage) : base(massage)
        {
            this.type = type;
        }
    }
}
