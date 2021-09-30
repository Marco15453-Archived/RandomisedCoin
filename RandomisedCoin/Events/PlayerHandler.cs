using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System;
using System.Collections.Generic;

namespace RandomisedCoin.Events
{
    internal sealed class PlayerHandler
    {
        private Config config = RandomisedCoin.Instance.Config;
        public Dictionary<Player, DateTime> activeCooldowns = new Dictionary<Player, DateTime>();

        public void onFlippingCoin(FlippingCoinEventArgs ev)
        {
            if(config.FlippingCooldown > 0 && activeCooldowns.ContainsKey(ev.Player) && DateTime.Now < (activeCooldowns[ev.Player] + TimeSpan.FromSeconds(config.FlippingCooldown)))
            {
                ev.Player.ShowHint(config.FlippingCooldownMessage.Replace("%REMAINING%", Math.Round(((activeCooldowns[ev.Player] + TimeSpan.FromSeconds(config.FlippingCooldown)) - DateTime.Now).TotalSeconds).ToString()));
                ev.IsAllowed = false;
                return;
            }

            // Apply Good Effect
            if (config.GoodSide == "tails" && ev.IsTails)
                Timing.CallDelayed(1.95f, () => ExtraMethods.applyGoodEffect(ev.Player));
            else if (config.GoodSide == "heads" && !ev.IsTails)
                Timing.CallDelayed(1.95f, () => ExtraMethods.applyGoodEffect(ev.Player));
            // Apply Bad Effect
            else if (config.BadSide == "tails" && ev.IsTails)
                Timing.CallDelayed(1.95f, () => ExtraMethods.applyBadEffect(ev.Player));
            else if (config.BadSide == "heads" && !ev.IsTails)
                Timing.CallDelayed(1.95f, () => ExtraMethods.applyBadEffect(ev.Player));

            if(config.FlippingCooldown > 0)
                activeCooldowns[ev.Player] = DateTime.Now;
        }
    }
}
