using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability {

	private string name;
	private string description;
	private Sprite icon;
	private List<AbilityBehaviors> behaviors;
	private bool requiresTarget;
	private bool canCastOnSelf;
	private int cooldown;  //in seconds
	private GameObject particleEffect; //needs assigned when creating the ability

	public Ability(string aname, Sprite aicon, List<AbilityBehaviors> abehaviors)
	{
		name = aname;
		icon = aicon;
		behaviors = new List<AbilityBehaviors> ();
		behaviors = abehaviors;
		cooldown = 0;
		requiresTarget = false;
		canCastOnSelf = false;
		description = "Default";
	}

	public Ability(string aname, string adescription, Sprite aicon, List<AbilityBehaviors> abehaviors, bool arequiretarget, int acooldown, GameObject aparticleeffect)
	{
		name = aname;
		icon = aicon;
		behaviors = new List<AbilityBehaviors> ();
		behaviors = abehaviors;
		cooldown = acooldown;
		requiresTarget = arequiretarget;
		canCastOnSelf = false;
		description = adescription;
		particleEffect = aparticleeffect;
	}

	public string AbilityName
	{
		get { return name; }
	}

	public string AbilityDescription
	{
		get { return description; }
	}

	public Sprite AbilityIcon
	{
		get { return icon; }
	}

	public int AbilityCooldown
	{
		get { return cooldown; }
	}

	public List<AbilityBehaviors> AbilityBehaviors
	{
		get { return behaviors; }
	}

	public void UseAbility()
	{
		
	}
}
