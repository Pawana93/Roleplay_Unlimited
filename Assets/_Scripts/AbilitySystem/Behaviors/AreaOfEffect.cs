using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class AreaOfEffect : AbilityBehaviors {

	private const string abName = "Area of Effect";
	private const string abDescription = "An area of damage!";
	private const BehaviorStartTimes startTime = BehaviorStartTimes.End; //on impact
	//If availabel
	//private const Sprite icon = Resources.Load("path to icon")

	private float areaRadius;	//radius of sphere collider
	private float effectDuration;	//how long the effect lasts
	private Stopwatch durationTimer = new Stopwatch();
	private float baseEffectDamage;
	private bool isOccupied;
	private float damageTickDuration;


	public AreaOfEffect(float bAreaRadius, float bEffectDuration, float bBaseEffectDamage) : base(new BasicObjectInformation(abName, abDescription), startTime)
	{
		areaRadius = bAreaRadius;
		effectDuration = bEffectDuration;
		baseEffectDamage = bBaseEffectDamage;
		isOccupied = false;
	}

	public override void PerformBehavior(GameObject objectHit)
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
		sc.isTrigger = true;



		StartCoroutine (AOE());
	}

	private IEnumerator AOE()
	{
		durationTimer.Start (); //turns on timer

		while(durationTimer.Elapsed.TotalSeconds <= effectDuration)
		{
			if(isOccupied)
			{
				//onDamage(list<targets>, baseDamage)
			}
			yield return new WaitForSeconds (damageTickDuration);
		}

		durationTimer.Stop ();
		durationTimer.Reset ();
		yield return null;
	}

	private void OnTriggerEnter(Collider other) 
	{
		if (isOccupied) 
		{
			//do damage here again
		}
		else
		{
			isOccupied = true;
		}
	}

	private void OnTriggerExit(Collider other) 
	{
		isOccupied = false;
	}

}
