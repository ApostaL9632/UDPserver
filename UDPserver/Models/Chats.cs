using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace UDPServer.Models
{
    public class Chats
    {
    
        public string Name;
        public List<Message> Messages = new List<Message>();
        public Chats(string chatName) 
        {
            this.Name = chatName;
        }
    }

}
