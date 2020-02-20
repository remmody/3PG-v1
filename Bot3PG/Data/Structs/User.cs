﻿using Discord;
using Discord.WebSocket;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Bot3PG.Data.Structs
{
    public class User
    {
        [BsonIgnore] private static ulong _id;
        [BsonRepresentation(BsonType.String)]
        [BsonId] public ulong ID { get; private set; }

        public int MessageCount { get; set; }
        public int Reputation { get; set; }
        public bool IsPrivate { get; set; }
        public int Votes { get; set; }
        public string[] Badges { get; set; } = new[] { "" };

        public XPCardSettings XPCard { get; set; } = new XPCardSettings();

        public class XPCardSettings
        {
            public string BackgroundURL { get; }
            public string UsernameColour { get; }
            public string DiscriminatorColour { get; }
            public string EXPColour { get; }
            public string RankColour { get; }
            public string ForegroundColour { get; }
            public string BackgroundColour { get; }
        }

        public User(IUser socketUser) { _id = socketUser.Id; ID = socketUser.Id; }
        public void Reinitialize() => XPCard ??= new XPCardSettings();
    }
}