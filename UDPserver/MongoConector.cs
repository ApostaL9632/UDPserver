using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDPServer.Models;



namespace UDPServer
{
    internal class MongoConector
    {
        private static MongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase chatDataBase = client.GetDatabase("ChatDB");
        private static IMongoCollection<Chat> chats = chatDataBase.GetCollection<Chat>("chats");
        //private static IMongoCollection<BsonDocument> chats = chatDataBase.GetCollection<BsonDocument>("Chats");
        public static void AddChat(Chat chat)
        {
            chats.InsertOne(chat);
        }
        public static Chat FindOneChat(Chat chat)
        {
            var filter = new BsonDocument { { "Name", chat.Name } };
            var chatsArray = chats.Find(filter).ToListAsync();
            foreach (var item in chatsArray.Result)
            {
                return item;
            }
            return null;
        }
    }
    
}
