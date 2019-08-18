﻿using Bot3PG.DataStructs;
using Bot3PG.Modules.General;
using Discord.Commands;
using Discord.WebSocket;
using System;
using Victoria;

namespace Bot3PG
{
    public class Global
    {
        public static DiscordSocketClient Client { get; private set; }
        public static LavaSocketClient Lavalink { get; private set; }
        public static Config Config { get; private set; }
        public static Config.DatabaseConfig DatabaseConfig { get; private set; }
        public static CommandService CommandService { get; private set; }

        private static DateTime _startTime;
        public static TimeSpan Uptime
        {
            get => DateTime.Now - _startTime;
            private set => Uptime = value;
        }

        public Global(DiscordSocketClient discordSocketClient, LavaSocketClient lavaSocketClient, Config config, CommandService commandService)
        {
            Client = discordSocketClient;
            Lavalink = lavaSocketClient;
            Config = config;
            CommandService = commandService;
            DatabaseConfig = config.DB;
            _startTime = DateTime.Now;
        }
    }
}