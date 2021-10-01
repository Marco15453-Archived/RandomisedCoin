using Exiled.API.Features;
using RandomisedCoin.Events;
using System;

using Player = Exiled.Events.Handlers.Player;

namespace RandomisedCoin
{
    public class RandomisedCoin : Plugin<Config>
    {
        internal static RandomisedCoin Instance;

        public override string Name => "Randomised Coin";
        public override string Author => "Marco15453";
        public override Version Version => new Version(1, 1, 1);
        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        private PlayerHandler playerHandler;

        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            playerHandler = new PlayerHandler();

            // Player
            Player.FlippingCoin += playerHandler.onFlippingCoin;
        }

        private void UnregisterEvents()
        {
            // Player
            Player.FlippingCoin -= playerHandler.onFlippingCoin;

            playerHandler = null;
        }
    }
}
