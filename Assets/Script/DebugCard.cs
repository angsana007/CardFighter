using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCard : MonoBehaviour {

	CardModel cardModel;
	int cardIndex = 0;
	//int deck = 15;

	public GameObject card;

	void Awake ()
	{
		cardModel = card.GetComponent<CardModel>();

	}


	void OnGUI ()
	{
		if (GUI.Button (new Rect (10, 10, 100, 28), "Hit me!")) {

			if (cardIndex == cardModel.faces.Length) 
			{
				cardIndex = 0;        
			} 
			else 
			{
				cardModel.cardIndex = cardIndex;
				cardModel.ToggleCard (true);
				cardIndex++;
			}

        }

    }

}
