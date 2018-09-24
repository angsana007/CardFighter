﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel : MonoBehaviour 
{
	SpriteRenderer spriteRenderer;
	public Sprite[] faces;
    public int cardIndex;

    public void ToggleCard (bool showCard)
	{
		if (showCard) {
			spriteRenderer.sprite = faces[cardIndex];
		}
	}

	void Awake ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

}

