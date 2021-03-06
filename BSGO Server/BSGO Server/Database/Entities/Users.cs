﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BSGO_Server.Database.Entities
{
    internal class Users
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("playerid")]
        [BsonRequired]
        public string PlayerId { get; set; }

        [BsonElement("sessioncode")]
        [BsonRequired]
        public string SessionCode { get; set; }

        [BsonElement("settings")]
        public IDictionary<string, string> settings { get; set; }

        [BsonElement("controlKeys")]
        public List<string> controlKeys { get; set; }

        // Should have more later
    }
}
