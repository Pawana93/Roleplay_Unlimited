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
	private bool isRandomOn;
	private float lifeDistance;

	public Ranged(float minDist, float maxDist, bool isRandom) : base(new BasicObjectInformation(name, description), startTime)
	{
		minDistance = minDist;
		maxDistance = maxDist;
		isRandomOn = isRandom;
	}

	public override void PerformBehavior(GameObject playerObject, GameObject objectHit)
	{
		lifeDistance = isRandomOn ? Random.Range (minDistance, maxDistance) : maxDistance;

		StartCoroutine (CheckDistance(playerObject.transform.position));
	}

	private IEnumerator CheckDistance(Vector3 startPosition) 
	{
		float tempdistance = Vector3.Distance (startPosition, this.transform.position);
		while (tempdistance < lifeDistance) 
		{
			tempdistance = Vector3.Distance (startPosition, this.transform.position);
		}

		this.gameObject.SetActive (false); //object pooling code if we want or destroy
		yield return null;
	}



	public float MinDistance {
		get{ return minDistance; }
	}

	public float MaxDistance {
		get{ return maxDistance; }
	}

}