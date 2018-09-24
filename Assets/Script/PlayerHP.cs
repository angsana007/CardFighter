using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {

    public int maxHealth;
    public int Health;
	public static PlayerHP thisHP;
    public Image imageBarHP;

    // Use this for initialization
    void Start() {
        thisHP = this;
        Health = maxHealth;
    }

    void loadSprite()
    {
        imageBarHP.sprite = Resources.Load<Sprite>("imageBar");
    }

	void Update ()
    {
        imageBarHP.fillAmount = Mathf.Lerp(imageBarHP.fillAmount, (float)Health / (float)maxHealth, 0.05f);
	}
}
