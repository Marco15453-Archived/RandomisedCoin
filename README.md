# Randomised Coin
A simple Exiled Plugin that gives some effects upon Landing on a side

# Important Notice
**If your server uses WaitAndChillReborn, and you don't want your players to flip a coin while their are waiting for round start make sure the config 'flipping_round' is disabled!**

***IF YOU STILL ALLOW THEM TO FLIP COINS IN THE WAITING LOBBY, YOUR PLAYERS MIGHT GET TELEPORTED OUT OF THE ROOM!***

# Types
If you want to know what Effects are currently supported [Click Here](https://github.com/Marco15453/RandomisedCoin/blob/master/TYPES.md)

# Config
Name | Type | Description | Default
---- | ---- | ----------- | -------
is_enabled | bool | Should the plugin be enabled? | true
flipping_round | bool | Should the player be available to flip a coin when round is not started? | false
good_side | string | What Side should trigger the Good Effects? (tails or heads) | tails
good_effects | HashSet | Good Effects when landed on the setting above | FasterSpeed, RandomItem, Heal, TeleportTo914
bad_side | string | What Side should trigger the Bad Effects? (tails or heads) | heads
bad_effects | HashSet | Bad Effects when landed on the setting above | DamagePlayer, RandomEffect, RandomRoom, SpawnActiveGrenade, TPtoSCP, KillPlayer
player_damage | int | Damage amount when it triggers DamagePlayer on bad_effects | 20
random_effects_duration | int | Random Effects Duration when it triggers RandomEffects on random_effects | 5
effect_hints | Dictionary | Hint that should be displayed when the effect occurs | [Click Here](https://github.com/Marco15453/RandomisedCoin#default-config)
random_items | HashSet | Random Items when it triggers RandomItems on good_effects | [Click Here](https://github.com/Marco15453/RandomisedCoin#default-config)
random_effects | HashSet | Random Effects when it triggers RandomEffects on bad_effects? | [Click Here](https://github.com/Marco15453/RandomisedCoin#default-config)
random_rooms | HashSet | Random Rooms when it triggers RandomRoom on bad_effects and/or good_effects | [Click Here](https://github.com/Marco15453/RandomisedCoin#default-config)

# Default Config
```yml
randomised_coin:
  # Should the plugin be enabled?
  is_enabled: true
  # Should the player be available to flip a coin when round is not started?
  flipping_round: false
  # Cooldown between each flipping to prevent spamming? (-1 = Disabled)
  flipping_cooldown: 30
  # Message when flipping is still on Cooldown
  flipping_cooldown_message: <color=red>Flipping a coin is still on cooldown! Please wait %REMAINING% Seconds
  # What Side should trigger the Good Effects? (tails or heads)
  good_side: tails
  # Good Effects when landed on the setting above
  good_effects:
  - FasterSpeed
  - RandomItem
  - Heal
  - TeleportTo914
  # What Side should trigger the Bad Effects? (tails or heads)
  bad_side: heads
  # Bad Effects when landed on the setting above
  bad_effects:
  - DamagePlayer
  - RandomEffect
  - RandomRoom
  - SpawnActiveGrenade
  - TPtoSCP
  - KillPlayer
  # Damage amount when it triggers DamagePlayer
  player_damage: 20
  # Random Effects Duration when it triggers RandomEffects
  random_effects_duration: 5
  # Hint that should be displayed when the effect occurs
  effect_hints:
    None: Nothing see to happen!
    TeleportTo914: You've been teleported to 914!
    KillPlayer: You've been terminated by Coin!
    RandomRoom: You've been teleported to a random Room!
    RandomItem: You've been given an random item!
    RandomEffect: You've been given an random effect!
    FasterSpeed: You've been given SCP-207 for %DURATION% Seconds!
    Heal: You've been healed completely!
    TPtoSCP: You had some bad timing, You've been teleported to an SCP!
    SpawnActiveGrenade: Run for your life, there is something among you!
    DamagePlayer: You step your toe on a wall, you took %DAMAGE% Health
  # Random Items when it triggers RandomItems?
  random_items:
  - Adrenaline
  - GunRevolver
  - Painkillers
  - Medkit
  - SCP207
  # Random Effects when it triggers RandomEffects?
  random_effects:
  - Amnesia
  - Asphyxiated
  - Bleeding
  - Blinded
  - Burned
  - Concussed
  - Disabled
  - Ensnared
  - Exhausted
  - Flashed
  - Hemorrhage
  - Poisoned
  - SinkHole
  # Random Rooms when it triggers RandomRoom?
  random_rooms:
  - EzCafeteria
  - EzCollapsedTunnel
  - EzConference
  - EzCrossing
  - EzCurve
  - EzDownstairsPcs
  - EzGateA
  - EzGateB
  - EzIntercom
  - EzPcs
  - EzShelter
  - EzStraight
  - EzTCross
  - EzUpstairsPcs
  - EzVent
  - Hcz049
  - Hcz079
  - Hcz096
  - Hcz106
  - Hcz939
  - HczArmory
  - HczChkpA
  - HczChkpB
  - HczCrossing
  - HczCurve
  - HczEzCheckpoint
  - HczHid
  - HczNuke
  - HczServers
  - HczStraight
  - HczTCross
  - HczTesla
  - Lcz012
  - Lcz173
  - Lcz914
  - LczAirlock
  - LczArmory
  - LczCafe
  - LczChkpA
  - LczChkpB
  - LczClassDSpawn
  - LczCrossing
  - LczCurve
  - LczGlassBox
  - LczPlants
  - LczStraight
  - LczTCross
  - LczToilets
  - Surface
```