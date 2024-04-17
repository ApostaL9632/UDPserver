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
        private static IMongoCollection<Chats> chats = chatDataBase.GetCollection<Chats>("chats");
        //private static IMongoCollection<BsonDocument> chats = chatDataBase.GetCollection<BsonDocument>("Chats");
        public static void AddChat(Chats chat)
        {
            chats.InsertOne(chat);
        }
    }
    
}
