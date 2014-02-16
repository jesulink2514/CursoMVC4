using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Infraestructure
{
    public interface IMessageProvider
    {
        string GetMessage();
    }

    public class MessageProvider : IMessageProvider
    {
        public string GetMessage()
        {
            return "Hello Universe!";
        }
    }

    public class SimpleMessageProvider : IMessageProvider
    {
        public string GetMessage()
        {
            return "Hello World!";
        }
    }
}