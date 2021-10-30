using Exiled.Events.EventArgs;

namespace RandomisedCoin.Events
{
    internal sealed class ServerHandler
    {
        public RandomisedCoin plugin;
        public ServerHandler(RandomisedCoin plugin) => this.plugin = plugin;

        public void OnRoundStarted()
        {
            plugin.activeCooldowns.Clear();
        }

        public void OnRoundEnded(RoundEndedEventArgs ev)
        {
            plugin.activeCooldowns.Clear();
        }
    }
}
