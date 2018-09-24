using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPlayer : MonoBehaviour {

	public Deck deck;
	public Deck playerH1;
	public Deck playerH2;
	public Deck playerH3;
	public Deck playerH4;

	SwipeManager swipe;
	//public GameController H1;
	float CooldownCard = 5;
	public bool isAttack = false;
	public bool isDefend = false;
	int hand;


	void Start ()
	{
		StartGame();
	}


	void StartGame ()
	{
			playerH1.Push(deck.Pop());
			playerH2.Push(deck.Pop());
			playerH3.Push(deck.Pop());
			playerH4.Push(deck.Pop());
		
	
	}

	void Update ()
	{
		Debug.Log("Card Empty");
			if (!playerH1.HasCards) 
			{
				playerH1.Push(deck.Pop());
			}else if (!playerH2.HasCards) 
			{
				Debug.Log("H2 Push");
				playerH2.Push(deck.Pop());
			}else if (!playerH3.HasCards) 
			{
				playerH3.Push(deck.Pop());
			}else if (!playerH4.HasCards) 
			{
				playerH4.Push(deck.Pop());
			}
		
	}

	void OnGUI ()
	{
		if (GUI.Button (new Rect (275, 200, 100, 28), "Attack")) {

			
			if (playerH1.HasCards) {
				isAttack = true;
				hand = 1;
				Attack ();
				playerH1.Pop();
				playerH1.Push(deck.Pop());
				//isAtteck = false;
			}

		}else 
		if (GUI.Button (new Rect (415, 200, 100, 28), "Attack")) {

			if (playerH2.HasCards) {
				isAttack = true;
				hand = 2;
				Attack ();
				playerH2.Pop();
				playerH2.Push(deck.Pop());
				//isAtteck = false;

			}

		}else 
		if (GUI.Button (new Rect (545, 200, 100, 28), "Attack")) {

			if (playerH3.HasCards) {
				isAttack = true;
				hand = 3;
				Attack ();
				playerH3.Pop();
				playerH3.Push(deck.Pop());
				//isAtteck = false;

			}

		}else 
		if (GUI.Button (new Rect (680, 200, 100, 28), "Attack")) {

			if (playerH4.HasCards) {
				isAttack = true;
				hand = 4;
				Attack ();
				playerH4.Pop();
				playerH4.Push(deck.Pop());
				//isAtteck = false;

			}

		}else
		if (GUI.Button (new Rect (280, 400, 100, 28), "Defend")) {

			if (playerH1.HasCards) {
				isDefend = true;
				hand = 1;
				Defend ();
				playerH1.Pop();
				playerH1.Push(deck.Pop());
				//isDefend = false;

			}
			

		}
		if (GUI.Button (new Rect (415, 400, 100, 28), "Defend")) {

			if (playerH2.HasCards) {
				isDefend = true;
				hand = 2;
				Defend ();
				playerH2.Pop();
				playerH2.Push(deck.Pop());
				//isDefend = false;

			}

		}else
		if (GUI.Button (new Rect (540, 400, 100, 28), "Defend")) {

				if (playerH3.HasCards) {
				isDefend = true;
				hand = 3;
				Defend ();
				playerH3.Pop();
				playerH3.Push(deck.Pop());
				//isDefend = false;


			}

		}else
		if (GUI.Button (new Rect (670, 400, 100, 28), "Defend")) {

				if (playerH4.HasCards) {
				isDefend = true;
				hand = 4;
				Defend ();
				playerH4.Pop();
				playerH4.Push(deck.Pop());
				//isDefend = false;

			}

		}

	}

	

	public int AttackPoint;

	public int Attack ()
	{
		
		if(isAttack == true && isDefend == true){
			DefendPoint = 0;
			isDefend = false;	
		}
	
		if (hand == 1) {
			if (isAttack = true) {
				int value = playerH1.HandValue ();
				AttackPoint = AttackPoint + value;

				Debug.Log (AttackPoint);
			}
		}else if (hand == 2) {
			if (isAttack = true) {
				int value = playerH2.HandValue ();
				AttackPoint = AttackPoint + value;

				Debug.Log (AttackPoint);
			}
		}else if (hand == 3) {
			if (isAttack = true) {
				int value = playerH3.HandValue ();
				AttackPoint = AttackPoint + value;

				Debug.Log (AttackPoint);
			}
		}else if (hand == 4) {
			if (isAttack = true) {
				int value = playerH4.HandValue ();
				AttackPoint = AttackPoint + value;

				Debug.Log (AttackPoint);
			}
		}
		return AttackPoint;

		}

	public int DefendPoint;

	public int Defend ()
	{	
		if(isAttack == true && isDefend == true){
			AttackPoint = 0;
			isAttack = false;	
		}

		if (hand == 1) {
			if (isDefend = true) {
				int value = playerH1.HandValue ();
				DefendPoint = DefendPoint + value;

				Debug.Log (DefendPoint);
			}
		}
		else if (hand == 2) {
			if (isDefend = true) {
				int value = playerH2.HandValue ();
				DefendPoint = DefendPoint + value;

				Debug.Log (DefendPoint);
			}
		}else if (hand == 3) {
			if (isDefend = true) {
				int value = playerH3.HandValue ();
				DefendPoint = DefendPoint + value;

				Debug.Log (DefendPoint);
			}
		}else if (hand == 4) {
			if (isDefend = true) {
				int value = playerH4.HandValue ();
				DefendPoint = DefendPoint + value;

				Debug.Log (DefendPoint);
			}
		}

		return DefendPoint;
	}

}
