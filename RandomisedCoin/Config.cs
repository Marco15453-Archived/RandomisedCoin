using Exiled.API.Interfaces;
using System.ComponentModel;
using RandomisedCoin.Collections;
using System.Collections.Generic;
using Exiled.API.Enums;

namespace RandomisedCoin
{
    public sealed class Config : IConfig
    {
        [Description("Should the plugin be enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("What Side should trigger the Good Effects? (tails or heads)")]
        public string GoodSide { get; set; } = "tails";

        [Description("Good Effects when landed on the setting above")]
        public HashSet<GoodEffectType> GoodEffects { get; set; } = new HashSet<GoodEffectType>
        {
            GoodEffectType.FasterSpeed,
            GoodEffectType.GiveItem,
            GoodEffectType.Heal,
            GoodEffectType.TeleportTo914
        };

        [Description("Good Effects Hint when this Effect Occur")]
        public Dictionary<GoodEffectType, string> GoodEffectsHint { get; set; } = new Dictionary<GoodEffectType, string>
        {
            { GoodEffectType.FasterSpeed, "OwO, The Coin gave you one SCP-207, gonna go fast!"},
            { GoodEffectType.GiveItem, "The Coin gave you an random item, lucky day" },
            { GoodEffectType.Heal, "The Coin healed you completly, gonna go fast!" },
            { GoodEffectType.TeleportTo914, "OwO, look at this! You got teleported to SCP-914" }
        };

        [Description("What Side should trigger the Bad Effects? (tails or heads)")]
        public string BadSide { get; set; } = "heads";

        [Description("Bad Effects when landed on the setting above")]
        public HashSet<BadEffectType> BadEffects { get; set; } = new HashSet<BadEffectType>
        {
            BadEffectType.DamagePlayer,
            BadEffectType.RandomEffect,
            BadEffectType.RandomRoom,
            BadEffectType.SpawnActiveGrenade,
            BadEffectType.TPtoSCP,
            BadEffectType.KillPlayer
        };

        [Description("Bad Effects Hint when this Effect Occur")]
        public Dictionary<BadEffectType, string> BadEffectsHint { get; set; } = new Dictionary<BadEffectType, string>
        {
            { BadEffectType.DamagePlayer, "The Coin didn't loved you! It took 20 Health from your Skin!"},
            { BadEffectType.KillPlayer, "The Coin decided to kill you! What a shame"},
            { BadEffectType.RandomEffect, "The Coin didn't loved you! It gave you a random bad effect!" },
            { BadEffectType.RandomRoom, "The Coin decided to teleported you in a random room!"},
            { BadEffectType.SpawnActiveGrenade, "You should run for your live!" },
            { BadEffectType.TPtoSCP, "You don't have much luck today, the coin teleported you to an SCP!" }
        };

        [Description("Effect Settings")]
        public int PlayerDamage { get; set; } = 20;

        public HashSet<ItemType> RandomItems { get; set; } = new HashSet<ItemType>
        {
            ItemType.Adrenaline,
            ItemType.GunRevolver,
            ItemType.Painkillers,
            ItemType.Medkit,
            ItemType.SCP207
        };

        public HashSet<EffectType> RandomEffects { get; set; } = new HashSet<EffectType>
        {
            EffectType.Amnesia,
            EffectType.Asphyxiated,
            EffectType.Bleeding,
            EffectType.Blinded,
            EffectType.Burned,
            EffectType.Concussed,
            EffectType.Disabled,
            EffectType.Ensnared,
            EffectType.Exhausted,
            EffectType.Flashed,
            EffectType.Hemorrhage,
            EffectType.Poisoned,
            EffectType.SinkHole
        };

        public int RandomEffectsDuration { get; set; } = 5;

        public HashSet<RoomType> RandomRooms { get; set; } = new HashSet<RoomType>
        {
            RoomType.EzCafeteria,
            RoomType.EzCollapsedTunnel,
            RoomType.EzConference,
            RoomType.EzCrossing,
            RoomType.EzCurve,
            RoomType.EzDownstairsPcs,
            RoomType.EzGateA,
            RoomType.EzGateB,
            RoomType.EzIntercom,
            RoomType.EzPcs,
            RoomType.EzShelter,
            RoomType.EzStraight,
            RoomType.EzTCross,
            RoomType.EzUpstairsPcs,
            RoomType.EzVent,
            RoomType.Hcz049,
            RoomType.Hcz079,
            RoomType.Hcz096,
            RoomType.Hcz106,
            RoomType.Hcz939,
            RoomType.HczArmory,
            RoomType.HczChkpA,
            RoomType.HczChkpB,
            RoomType.HczCrossing,
            RoomType.HczCurve,
            RoomType.HczEzCheckpoint,
            RoomType.HczHid,
            RoomType.HczNuke,
            RoomType.HczServers,
            RoomType.HczStraight,
            RoomType.HczTCross,
            RoomType.HczTesla,
            RoomType.Lcz012,
            RoomType.Lcz173,
            RoomType.Lcz914,
            RoomType.LczAirlock,
            RoomType.LczArmory,
            RoomType.LczCafe,
            RoomType.LczChkpA,
            RoomType.LczChkpB,
            RoomType.LczClassDSpawn,
            RoomType.LczCrossing,
            RoomType.LczCurve,
            RoomType.LczGlassBox,
            RoomType.LczPlants,
            RoomType.LczStraight,
            RoomType.LczTCross,
            RoomType.LczToilets,
            RoomType.Surface
        };
    }
}
