using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour {

	public int maxHealth;
    public int Health;
	public static EnemyHP thisHP;
    public Image imageBarHP;

	
	void Start () {
		thisHP = this;
        Health = maxHealth;
	}
	
	void loadSprite()
    {
        imageBarHP.sprite = Resources.Load<Sprite>("imageBar");
    }

	void Update () {
		imageBarHP.fillAmount = Mathf.Lerp(imageBarHP.fillAmount, (float)Health / (float)maxHealth, 0.05f);
	}
}
