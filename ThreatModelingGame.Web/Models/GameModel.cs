﻿using System;
using ThreadModelingGame.Core;

namespace ThreatModelingGame.Web.Models
{
    public sealed class GameModel
    {
        private readonly IGame _game;
        private readonly PlayerInGame _player;

        public GameModel(IGame game, PlayerInGame player)
        {
            _game = game;
            _player = player;
        }

        public Guid Id { get { return _game.Id; } }
        public string Name { get { return _game.Name; } }

        public PlayerInGame Player
        {
            get { return _player; }
        }
    }
}