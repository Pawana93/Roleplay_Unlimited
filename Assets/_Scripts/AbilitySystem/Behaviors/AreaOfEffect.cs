using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class AreaOfEffect : AbilityBehaviors {

	private const string name = "Area of Effect";
	private const string description = "An area of damage!";
	private const BehaviorStartTimes startTime = BehaviorStartTimes.End; //on impact
	//If availabel
	//private const Sprite icon = Resources.Load("path to icon")

	private float areaRadius;	//radius of sphere collider
	private float effectDuration;	//how long the effect lasts
	private Stopwatch durationTimer = new Stopwatch();
	private float baseEffectDamage;


	public AreaOfEffect(float bAreaRadius, float bEffectDuration, float bBaseEffectDamage) : base(new BasicObjectInformation(name, description), startTime)
	{
		areaRadius = bAreaRadius;
		effectDuration = bEffectDuration;
		baseEffectDamage = bBaseEffectDamage;
	}

	public override void PerformBehavior(Vector3 startPosition)
	{
		SphereCollider sc;

		if (this.gameObject.GetComponent<SphereCollider> () == null) 
		{
			sc = this.gameObject.AddComponent<SphereCollider> ();
		}
		else
		{
			sc = this.gameObject.GetComponent<SphereCollider> ();
		}

		sc.radius = areaRadius;



		StartCoroutine (AOE());
	}

	private IEnumerator AOE()
	{
		durationTimer.Start (); //turns on timer

		while(durationTimer.Elapsed.TotalSeconds <= effectDuration)
		{
			//do damage
		}

		durationTimer.Stop ();
		durationTimer.Reset ();
		yield return null;
	}


}
