using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBehaviors : MonoBehaviour {

	private BasicObjectInformation objectInfo;
	private BehaviorStartTimes startTime;

	public AbilityBehaviors(BasicObjectInformation basicInfo, BehaviorStartTimes sTime)
	{
		objectInfo = basicInfo;
		startTime = sTime;
	}

	public enum BehaviorStartTimes
	{
		Beginning,
		Middle,
		End
	}

	//game object wanted, target, 
	public virtual void PerformBehavior(GameObject objectHit)
	{
		Debug.LogWarning ("NEED TO ADD BEHAVIOR");
	}

	public BasicObjectInformation AbilityBehaviorInfo 
	{
		get { return objectInfo; }
	}

	public BehaviorStartTimes AbilityBehaviorStartTime 
	{
		get { return startTime; }
	}
}
