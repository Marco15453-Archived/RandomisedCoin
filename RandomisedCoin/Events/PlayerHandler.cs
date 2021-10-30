using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System;
using System.Collections.Generic;

namespace RandomisedCoin.Events
{
    internal sealed class PlayerHandler
    {
        public RandomisedCoin plugin;
        public PlayerHandler(RandomisedCoin plugin) => this.plugin = plugin;

        public void onFlippingCoin(FlippingCoinEventArgs ev)
        {
            if (!Round.IsStarted && !plugin.Config.FlippingRound)
                return;


            if(plugin.Config.FlippingCooldown > 0 && plugin.activeCooldowns.ContainsKey(ev.Player) && DateTime.Now < (plugin.activeCooldowns[ev.Player] + TimeSpan.FromSeconds(plugin.Config.FlippingCooldown)))
            {
                ev.Player.ShowHint(plugin.Config.FlippingCooldownMessage.Replace("%REMAINING%", Math.Round(((plugin.activeCooldowns[ev.Player] + TimeSpan.FromSeconds(plugin.Config.FlippingCooldown)) - DateTime.Now).TotalSeconds).ToString()));
                ev.IsAllowed = false;
                return;
            }

            // Apply Good Effect
            if (plugin.Config.GoodSide == "tails" && ev.IsTails)
                Timing.CallDelayed(1.95f, () => plugin.Extensions.ApplyEffect(ev.Player, true));
            else if (plugin.Config.GoodSide == "heads" && !ev.IsTails)
                Timing.CallDelayed(1.95f, () => plugin.Extensions.ApplyEffect(ev.Player, true));
            // Apply Bad Effect
            else if (plugin.Config.BadSide == "tails" && ev.IsTails)
                Timing.CallDelayed(1.95f, () => plugin.Extensions.ApplyEffect(ev.Player, false));
            else if (plugin.Config.BadSide == "heads" && !ev.IsTails)
                Timing.CallDelayed(1.95f, () => plugin.Extensions.ApplyEffect(ev.Player, false));

            if(plugin.Config.FlippingCooldown > 0)
                plugin.activeCooldowns[ev.Player] = DateTime.Now;
        }
    }
}
