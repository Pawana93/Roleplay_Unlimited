using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;

public class Ability_Use : MonoBehaviour {

	public GameObject fireballPrefab;
	private FireballAbility fba;
	private Stopwatch abilityCooldownTimer;
	public float forceMultiplier;
	private Button button;
	private Image fillImage;

	public void OnAbilityUse(GameObject btn)
	{
		//if ability is not on cool down use it
		fillImage = btn.transform.GetChild(0).gameObject.GetComponent<Image>();
		UnityEngine.Debug.Log(btn.transform.GetChild(0).gameObject.name);
		button = btn.GetComponent<Button>();
		button.interactable = false;
		fillImage.fillAmount = 1;
		abilityCooldownTimer = new Stopwatch();
		abilityCooldownTimer.Start();
		fba = new FireballAbility();

		GameObject go = Instantiate<GameObject>(fireballPrefab);

		StartCoroutine(SpinImage());
	}	

	private IEnumerator SpinImage()
	{
		UnityEngine.Debug.Log(fba.AbilityCooldown);
		while(abilityCooldownTimer.IsRunning && abilityCooldownTimer.Elapsed.TotalSeconds < fba.AbilityCooldown)
		{
			UnityEngine.Debug.Log(fillImage.fillAmount);
			fillImage.fillAmount = ((float)abilityCooldownTimer.Elapsed.TotalSeconds / fba.AbilityCooldown);
			yield return null;
		}
		fillImage.fillAmount = 0;
		button.interactable = true;
		abilityCooldownTimer.Stop();
		abilityCooldownTimer.Reset();

		yield return null;
	}
}
