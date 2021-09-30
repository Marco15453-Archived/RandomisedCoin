using Exiled.API.Enums;
using Exiled.API.Features;
using RandomisedCoin.Collections;
using System;
using System.Linq;

namespace RandomisedCoin
{
    public static class ExtraMethods
    {
        private static Config config = RandomisedCoin.Instance.Config;
        private static Random rnd = new Random();

        public static void applyGoodEffect(Player ply)
        {
            GoodEffectType effect = config.GoodEffects.ElementAt(rnd.Next(config.GoodEffects.Count));

            if (config.GoodEffectsHint.ContainsKey(effect))
                ply.ShowHint(config.GoodEffectsHint[effect]);

            switch(effect)
            {
                case GoodEffectType.None:
                    break;
                case GoodEffectType.RandomItem:
                    ply.AddItem(config.RandomItems.ElementAt(rnd.Next(config.RandomItems.Count)));
                    break;
                case GoodEffectType.Heal:
                    ply.Health = ply.MaxHealth;
                    break;
                case GoodEffectType.TeleportTo914:
                    ply.Position = Map.Rooms.First(r => r.Type == RoomType.Lcz914).transform.position + UnityEngine.Vector3.up * 1.5f;
                    break;
                case GoodEffectType.RandomRoom:
                    ply.Position = Map.Rooms.First(r => r.Type == config.RandomRooms.ElementAt(rnd.Next(config.RandomRooms.Count))).transform.position + UnityEngine.Vector3.up * 1.5f;
                    break;
                case GoodEffectType.FasterSpeed:
                    ply.EnableEffect(EffectType.Scp207, config.RandomEffectsDuration, true);
                    break;
            }
        }

        public static void applyBadEffect(Player ply)
        {
            BadEffectType effect = config.BadEffects.ElementAt(rnd.Next(config.BadEffects.Count));

            if (effect == BadEffectType.TPtoSCP && Player.Get(Team.SCP).Count() <= 0)
                effect = config.BadEffects.ElementAt(rnd.Next(config.BadEffects.Count));

            if (config.BadEffectsHint.ContainsKey(effect))
                ply.ShowHint(config.BadEffectsHint[effect], 5);

            switch(effect)
            {
                case BadEffectType.None:
                    break;
                case BadEffectType.DamagePlayer:
                    ply.Hurt(config.PlayerDamage);
                    break;
                case BadEffectType.KillPlayer:
                    ply.Kill(DamageTypes.None);
                    break;
                case BadEffectType.RandomEffect:
                    ply.EnableEffect(config.RandomEffects.ElementAt(rnd.Next(config.RandomEffects.Count)), config.RandomEffectsDuration, true);
                    break;
                case BadEffectType.RandomRoom:
                    ply.Position = Map.Rooms.First(r => r.Type == config.RandomRooms.ElementAt(rnd.Next(config.RandomRooms.Count))).transform.position + UnityEngine.Vector3.up * 1.5f;
                    break;
                case BadEffectType.SpawnActiveGrenade:
                    ply.ThrowGrenade(GrenadeType.FragGrenade);
                    break;
                case BadEffectType.TPtoSCP:
                    ply.Position = Player.Get(Team.SCP).ElementAt(rnd.Next(Player.Get(Team.SCP).Count())).Position + UnityEngine.Vector3.up * 1.5f;
                    break;
            }
        }
    }
}
