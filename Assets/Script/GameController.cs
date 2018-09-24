using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	float CooldownCard = 5;
	Deck deck ;
	
	// Use this for initialization
	void OnClick ()
	{

	}
	
	// Update is called once per frame

	public int Attack ()
	{	int value = deck.HandValue();
		int AttackPoint = 0;

		/*if(CooldownCard != 0)
		{
			AttackPoint = AttackPoint + value;
		}*/

		foreach (int card in deck.GetCards()) 
		{	
			int cardvalue = card % 5;
			Debug.Log(cardvalue);
			AttackPoint = AttackPoint + cardvalue;
			Debug.Log(AttackPoint);
		}

		return AttackPoint;
	
	}

	public int Defend ()
	{	int value = deck.HandValue();
		int DefendPoint = 0;
		if(CooldownCard != 0)
		{
			DefendPoint = DefendPoint + value;

		}

		return DefendPoint;
	}

}
