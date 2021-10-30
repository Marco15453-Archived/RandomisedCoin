using Exiled.API.Features;
using RandomisedCoin.Events;
using System;
using System.Collections.Generic;
using Player = Exiled.Events.Handlers.Player;
using Server = Exiled.Events.Handlers.Server;

namespace RandomisedCoin
{
    public class RandomisedCoin : Plugin<Config>
    {
        public override string Name => "Randomised Coin";
        public override string Author => "Marco15453";
        public override Version Version => new Version(1, 2, 0);
        public override Version RequiredExiledVersion => new Version(3, 3, 1);

        public Dictionary<Exiled.API.Features.Player, DateTime> activeCooldowns = new Dictionary<Exiled.API.Features.Player, DateTime>();

        private ServerHandler serverHandler;
        private PlayerHandler playerHandler;

        public Extensions Extensions;

        public override void OnEnabled()
        {
            Extensions = new Extensions(this);
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            Extensions = null;
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            serverHandler = new ServerHandler(this);
            playerHandler = new PlayerHandler(this);

            // Server
            Server.RoundStarted += serverHandler.OnRoundStarted;
            Server.RoundEnded += serverHandler.OnRoundEnded;

            // Player
            Player.FlippingCoin += playerHandler.onFlippingCoin;
        }

        private void UnregisterEvents()
        {
            // Server
            Server.RoundStarted -= serverHandler.OnRoundStarted;
            Server.RoundEnded -= serverHandler.OnRoundEnded;

            // Player
            Player.FlippingCoin -= playerHandler.onFlippingCoin;

            playerHandler = null;
            serverHandler = null;
        }
    }
}
