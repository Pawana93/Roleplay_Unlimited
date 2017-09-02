using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability {

	private BasicObjectInformation objectInfo;
	private List<AbilityBehaviors> behaviors;
	private bool requiresTarget;
	private bool canCastOnSelf;
	private int cooldown;  //in seconds
	private GameObject particleEffect; //needs assigned when creating the ability

	public Ability(BasicObjectInformation abasicinfo, List<AbilityBehaviors> abehaviors)
	{
		objectInfo = abasicinfo;
		behaviors = new List<AbilityBehaviors> ();
		behaviors = abehaviors;
		cooldown = 0;
		requiresTarget = false;
		canCastOnSelf = false;
	}

	public Ability(BasicObjectInformation abasicinfo, List<AbilityBehaviors> abehaviors, bool arequiretarget, int acooldown, GameObject aparticleeffect)
	{
		objectInfo = abasicinfo;
		behaviors = new List<AbilityBehaviors> ();
		behaviors = abehaviors;
		cooldown = acooldown;
		requiresTarget = arequiretarget;
		canCastOnSelf = false;
		particleEffect = aparticleeffect;
	}

	public string AbilityInfo {
		get { return objectInfo; }
	}

	public int AbilityCooldown
	{
		get { return cooldown; }
	}

	public List<AbilityBehaviors> AbilityBehaviors
	{
		get { return behaviors; }
	}


	//This is the method that will be called anytime we use ability
	public void UseAbility()
	{
		
	}
}