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

	public virtual void PerformBehavior(Vector3 startPosition)
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
