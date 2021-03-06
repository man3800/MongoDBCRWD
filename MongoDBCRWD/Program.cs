using MongoDB.Driver;
using MongoDBCRWD.Models;
using System;
using System.Collections.Generic;

namespace MongoDBCRWD
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://172.1.50.51:27017");
            var database = client.GetDatabase("school");

            var peopleDB = database.GetCollection<People>("people");

            //var people = new People() { name = "홍길동이 어디고?", age = 28 };
            var people = new People() { id = "623a7178f47ef0eb3042dd20", name = "홍길동이 어디고? 니 뒤에 있다.", age = 38 };

            //insert
            //peopleDB.InsertOne(people);

            //select
            //List<People> lst = peopleDB.Find(d => true).ToList();

            //update
            peopleDB.ReplaceOne(d => d.id == "623a7178f47ef0eb3042dd20", people);

            //delete
            //peopleDB.DeleteOne(d => d.id == "62398f98b83e571add593289");

            /*
             * vs project 마다 mongodb.driver설치
                install-package mongdb.driver   
             * pc MongoDB설치
                환경변수 path add "C:\Program Files\MongoDB\Server\5.0\bin"
             * dos
                C:\Users\admin>mongo             
                MongoDB Enterprise > show dbs
                admin    0.000GB
                config   0.000GB
                local    0.000GB
                school   0.000GB
                startup  0.000GB
                MongoDB Enterprise > use school
                switched to db school
                MongoDB Enterprise > db
                school
                MongoDB Enterprise > db.people.find()
                { "_id" : ObjectId("62398f98b83e571add593289"), "name" : "길용이 잘하고 있나?", "age" : 14 }
                MongoDB Enterprise >
             */
        }
    }
}
