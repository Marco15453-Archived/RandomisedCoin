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

        [Description("Should the player be available to flip a coin when round is not started?")]
        public bool FlippingRound { get; set; } = false;

        [Description("Cooldown between each flipping to prevent spamming? (-1 = Disabled)")]
        public int FlippingCooldown { get; set; } = 30;

        [Description("Message when flipping is still on Cooldown")]
        public string FlippingCooldownMessage { get; set; } = "<color=red>Flipping a coin is still on cooldown! Please wait %REMAINING% Seconds";

        [Description("What Side should trigger the Good Effects? (tails or heads)")]
        public string GoodSide { get; set; } = "tails";

        [Description("Good Effects when landed on the setting above")]
        public HashSet<CoinEffectType> GoodEffects { get; set; } = new HashSet<CoinEffectType>
        {
            CoinEffectType.FasterSpeed,
            CoinEffectType.RandomItem,
            CoinEffectType.Heal,
            CoinEffectType.TeleportTo914
        };

        [Description("What Side should trigger the Bad Effects? (tails or heads)")]
        public string BadSide { get; set; } = "heads";

        [Description("Bad Effects when landed on the setting above")]
        public HashSet<CoinEffectType> BadEffects { get; set; } = new HashSet<CoinEffectType>
        {
            CoinEffectType.DamagePlayer,
            CoinEffectType.RandomEffect,
            CoinEffectType.RandomRoom,
            CoinEffectType.SpawnActiveGrenade,
            CoinEffectType.TPtoSCP,
            CoinEffectType.KillPlayer
        };

        [Description("Damage amount when it triggers DamagePlayer")]
        public int PlayerDamage { get; set; } = 20;

        [Description("Random Effects Duration when it triggers RandomEffects")]
        public int RandomEffectsDuration { get; set; } = 5;

        [Description("Hint that should be displayed when the effect occurs")]
        public Dictionary<CoinEffectType, string> EffectHints { get; set; } = new Dictionary<CoinEffectType, string>
        {
            { CoinEffectType.None, "Nothing see to happen!"},
            { CoinEffectType.TeleportTo914, "You've been teleported to 914!" },
            { CoinEffectType.KillPlayer, "You've been terminated by Coin!" },
            { CoinEffectType.RandomRoom, "You've been teleported to a random Room!" },
            { CoinEffectType.RandomItem, "You've been given an random item!" },
            { CoinEffectType.RandomEffect, "You've been given an random effect!" },
            { CoinEffectType.FasterSpeed, "You've been given SCP-207 for %DURATION% Seconds!" },
            { CoinEffectType.Heal, "You've been healed completely!" },
            { CoinEffectType.TPtoSCP, "You had some bad timing, You've been teleported to an SCP!" },
            { CoinEffectType.SpawnActiveGrenade, "Run for your life, there is something among you!" },
            { CoinEffectType.DamagePlayer, "You step your toe on a wall, you took %DAMAGE% Health" }
        };

        [Description("Random Items when it triggers RandomItems?")]
        public HashSet<ItemType> RandomItems { get; set; } = new HashSet<ItemType>
        {
            ItemType.Adrenaline,
            ItemType.GunRevolver,
            ItemType.Painkillers,
            ItemType.Medkit,
            ItemType.SCP207
        };

        [Description("Random Effects when it triggers RandomEffects?")]
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

        [Description("Random Rooms when it triggers RandomRoom?")]
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
