using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
    public class Greeter
    {
        private string _GreetingMessage;
        public string GreetingMessage
        {
            get
            {
                return _GreetingMessage;
            }
            private set
            {
                _GreetingMessage = value;
            }
        }

        public string FarewellMessage { get; private set; }

        public Greeter(string greeting, string farewell)
        {
            GreetingMessage = greeting;
            FarewellMessage = farewell;
        }

        public string SayGreeting(string name)
        {
            return name + ", " + GreetingMessage;
        }

        public string SayGreeting()
        {
            return GreetingMessage;
        }

        public string SayGoodbye(string name)
        {
            return name + " - " + FarewellMessage;
        }

        public string SayGoodbye()
        {
            return FarewellMessage;
        }
    }
}
