using Exiled.Events.EventArgs;
using MEC;

namespace RandomisedCoin.Events
{
    internal sealed class PlayerHandler
    {
        private Config config = RandomisedCoin.Instance.Config;

        public void onFlippingCoin(FlippingCoinEventArgs ev)
        {
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
        }
    }
}
