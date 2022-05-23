using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1_DS1.Entity
{
    public class Post:User
    {
        private string id = ObjectId.GenerateNewId().ToString();
        public string descr { get; set;}
        public string img { get; set;}
        public float rate { get; set;}
        public int idOwner { get; set;}
        public string title { get; set;}
        public float price { get; set;}
    }
}
