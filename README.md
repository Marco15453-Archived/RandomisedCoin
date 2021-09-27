# Randomised Coin
A simple Exiled Plugin that gives some effects upon Landing on a side

# Types
If you want to know what Effects are currently supported [Click Here]()

# Config
Name | Type | Description | Default
---- | ---- | ----------- | -------
is_enabled | bool | Should the plugin be enabled? | true
good_side | string | What Side should trigger the Good Effects? (tails or heads) | tails
good_effects | HashSet | Good Effects when landed on the setting above | FasterSpeed, RandomItem, Heal, TeleportTo914
good_effects_hint | Dictionary | Good Effects Hint when this Effect Occur | [Click Here](https://github.com/Marco15453/RandomisedCoin#default-config)
bad_side | string | What Side should trigger the Bad Effects? (tails or heads) | heads
bad_effects | HashSet | Bad Effects when landed on the setting above | DamagePlayer, RandomEffect, RandomRoom, SpawnActiveGrenade, TPtoSCP, KillPlayer
bad_effects_hint | Dictionary | Bad Effects Hint when this Effect Occur | [Click Here](https://github.com/Marco15453/RandomisedCoin#default-config)
player_damage | int | Damage amount when it triggers DamagePlayer on bad_effects | 20
random_effects_duration | int | Random Effects Duration when it triggers RandomEffects on random_effects | 5
random_items | HashSet | Random Items when it triggers RandomItems on good_effects | [Click Here](https://github.com/Marco15453/RandomisedCoin#default-config)
random_effects | HashSet | Random Effects when it triggers RandomEffects on bad_effects? | [Click Here](https://github.com/Marco15453/RandomisedCoin#default-config)
random_rooms | HashSet | Random Rooms when it triggers RandomRoom on bad_effects and/or good_effects | [Click Here](https://github.com/Marco15453/RandomisedCoin#default-config)

# Default Config
```yml
randomised_coin:
  # Should the plugin be enabled?
  is_enabled: true
  # What Side should trigger the Good Effects? (tails or heads)
  good_side: tails
  # Good Effects when landed on the setting above
  good_effects:
  - FasterSpeed
  - RandomItem
  - Heal
  - TeleportTo914
  # Good Effects Hint when this Effect Occur
  good_effects_hint:
    FasterSpeed: OwO, The Coin gave you one SCP-207, gonna go fast!
    RandomItem: The Coin gave you an random item, lucky day
    Heal: The Coin healed you completly, gonna go fast!
    TeleportTo914: OwO, look at this! You got teleported to SCP-914
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
  # Bad Effects Hint when this Effect Occur
  bad_effects_hint:
    DamagePlayer: The Coin didn't loved you! It took 20 Health from your Skin!
    KillPlayer: The Coin decided to kill you! What a shame
    RandomEffect: The Coin didn't loved you! It gave you a random bad effect!
    RandomRoom: The Coin decided to teleported you in a random room!
    SpawnActiveGrenade: You should run for your live!
    TPtoSCP: You don't have much luck today, the coin teleported you to an SCP!
  # Damage amount when it triggers DamagePlayer on bad_effects
  player_damage: 20
  # Random Effects Duration when it triggers RandomEffects on random_effects
  random_effects_duration: 5
  # Random Items when it triggers RandomItems on good_effects
  random_items:
  - Adrenaline
  - GunRevolver
  - Painkillers
  - Medkit
  - SCP207
  # Random Effects when it triggers RandomEffects on bad_effects?
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
  # Random Rooms when it triggers RandomRoom on bad_effects and/or good_effects
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