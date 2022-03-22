using MongoDB.Driver;
using MongoDBCRWD.Models;
using System;

namespace MongoDBCRWD
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("school");

            var peopleDB = database.GetCollection<People>("people");

            var people = new People() { name = "홍길이", age = 12 };
            peopleDB.InsertOne(people);

        }
    }
}
