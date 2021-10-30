using Exiled.API.Enums;
using Exiled.API.Features;
using RandomisedCoin.Collections;
using System.Linq;
using UnityEngine;
using Random = System.Random;

namespace RandomisedCoin
{
    public class Extensions
    {
        public RandomisedCoin plugin;
        public Extensions(RandomisedCoin plugin) => this.plugin = plugin;

        private Random rnd = new Random();

        public void ApplyEffect(Player ply, bool good)
        {
            int count = good ? plugin.Config.GoodEffects.Count : plugin.Config.BadEffects.Count;

            CoinEffectType effect = good ? plugin.Config.GoodEffects.ElementAt(rnd.Next(count)) : plugin.Config.BadEffects.ElementAt(rnd.Next(count));

            if (Player.Get(Team.SCP).Count() <= 0 && effect == CoinEffectType.TPtoSCP)
                ApplyEffect(ply, good);

            if (plugin.Config.EffectHints.ContainsKey(effect) && plugin.Config.EffectHints.Count > 0)
                ply.ShowHint(plugin.Config.EffectHints[effect].Replace("%DURATION%", plugin.Config.RandomEffectsDuration.ToString()).Replace("%DAMAGE%", plugin.Config.PlayerDamage.ToString()));

            switch (effect)
            {
                case CoinEffectType.None:
                    break;
                case CoinEffectType.Heal:
                    ply.Health = ply.MaxHealth;
                    break;
                case CoinEffectType.DamagePlayer:
                    ply.Hurt(plugin.Config.PlayerDamage, DamageTypes.Bleeding, "Coin");
                    break;
                case CoinEffectType.FasterSpeed:
                    ply.EnableEffect(EffectType.Scp207, plugin.Config.RandomEffectsDuration);
                    break;
                case CoinEffectType.KillPlayer:
                    ply.Kill();
                    break;
                case CoinEffectType.RandomEffect:
                    ply.EnableEffect(plugin.Config.RandomEffects.ElementAt(rnd.Next(0, plugin.Config.RandomEffects.Count)), plugin.Config.RandomEffectsDuration);
                    break;
                case CoinEffectType.RandomItem:
                    ply.AddItem(plugin.Config.RandomItems.ElementAt(rnd.Next(0, plugin.Config.RandomItems.Count)));
                    break;
                case CoinEffectType.RandomRoom:
                    RoomType roomType = plugin.Config.RandomRooms.ElementAt(rnd.Next(0, plugin.Config.RandomRooms.Count));
                    ply.Position = Map.Rooms.FirstOrDefault(r => r.Type == roomType).transform.position + Vector3.up * 1.5f;
                    break;
                case CoinEffectType.TeleportTo914:
                    ply.Position = Map.Rooms.FirstOrDefault(r => r.Type == RoomType.Lcz914).transform.position + Vector3.up * 1.5f;
                    break;
                case CoinEffectType.SpawnActiveGrenade:
                    ply.ThrowGrenade(GrenadeType.FragGrenade);
                    break;
                case CoinEffectType.TPtoSCP:
                    Player scpPlayer = Player.Get(Team.SCP).Where(p => p.Role != RoleType.Scp079).ElementAt(rnd.Next(0, Player.Get(Team.SCP).Count()));
                    ply.Position = scpPlayer.Position;
                    break;
            }
        }
    }
}
