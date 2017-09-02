using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : AbilityBehaviors {

	private const string name = "Ranged";
	private const string description = "A ranged attack!";
	private const BehaviorStartTimes startTime = BehaviorStartTimes.Beginning;
	//If availabel
	//private const Sprite icon = Resources.Load("path to icon")

	//customize behavior
	private float minDistance;
	private float maxDistance;

	public Ranged(float minDist, float maxDist) : base(new BasicObjectInformation(name, description), startTime)
	{

	}

	public float MinDistance {
		get{ return minDistance; }
	}

	public float MaxDistance {
		get{ return maxDistance; }
	}

}