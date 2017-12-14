using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Slow : AbilityBehaviors {

	private const string abName = "Slow";
	private const string abDescription = "Slow the moving speed!";
	private const BehaviorStartTimes startTime = BehaviorStartTimes.End;	//on impact
	//private const Sprite icon = Resources.Load();

	private float effectDuration; //how long the effect lasts
	private float slowPercent;

	public Slow(float ed, float sp) : base(new BasicObjectInformation(abName, abDescription), startTime)
	{
		effectDuration = ed;
		slowPercent = sp;
	}

	public override void PerformBehavior(GameObject playerObject, GameObject objectHit) 
	{
		StartCoroutine(SlowMovement(objectHit));
	}

	private IEnumerator SlowMovement(GameObject objectHit){
		
		//if(objectHit.GetComponent<"Movement">() != null)
		//get movement var
		//apply percentage slow

		yield return new WaitForSeconds(effectDuration);

		//reset objects movement speed 

		yield return null;
	}
}
