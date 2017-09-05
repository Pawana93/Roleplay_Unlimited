using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    public int currentHP;
    public int maxHP;
    public int currentMP;
    public int maxMP;
    public int level=1;
    public int exp;
    public int strength;
    public int stamina;
    public int intellect;

    public Slider healthSlider;
    public Slider manaSlider;
    public Slider expSlider;
    public Text txtCurHP;
    public Text txtMaxHP;
    public Text txtMaxMP;
    public Text txtCurMP;




	// Use this for initialization
	void Start () {
        strength = 30;
        stamina = 50;
        intellect = 20;
        maxHP = level + (level * stamina * 2);
        currentHP = maxHP;
        maxMP = level + (level * intellect * 1);
        currentMP = maxMP;
        exp = 0;
        healthSlider.maxValue = maxHP;
        manaSlider.maxValue = maxMP;
	}
	
	// Update is called once per frame
	void Update () {
        healthSlider.value = currentHP;
        manaSlider.value = currentMP;
        txtMaxHP.text = maxHP.ToString();
        txtMaxMP.text = maxMP.ToString();
        txtCurHP.text = currentHP.ToString();
        txtCurMP.text = currentMP.ToString();
	}
}
