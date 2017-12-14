using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAbility : Ability{

	private const string aName = "Fire Ball";
	private const string aDescription = "A firey mass that explodes on impact!";
	//private const Sprite icon = Resources.Load();

	private const float rangedMinDist = 10f;
	private const float rangedMaxDist = 20f;
	private const bool rangedIsRandom = true;

	private const float AOERadius = 2f;
	private const float AOEDuration = 2.3f;
	private const float baseEffectDamageAOE = 50f;

	public const float DOTLength = 45f;
	private const float baseEffectDamageDOT = 10f;
	private const float dotTickDuration = 5f;


	//ranged, at the start, max distance, requires a target
	public FireballAbility() 
		: base(new BasicObjectInformation(aName, aDescription))
	{
		this.AbilityBehaviors.Add(new Ranged(rangedMinDist, rangedMaxDist, rangedIsRandom));
		this.AbilityBehaviors.Add(new AreaOfEffect(AOERadius, AOEDuration, baseEffectDamageAOE));
		this.AbilityBehaviors.Add(new DamageOverTime(DOTLength, baseEffectDamageDOT, dotTickDuration));
	}
}