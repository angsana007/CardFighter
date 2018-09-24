using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Deck))]
public class DeckView : MonoBehaviour 
{
	Deck deck;
	Dictionary<int, CardView> fetchedCards;
	public int lastCount;
	public float reloadTime = 30f;
	//public bool faceUp = false;
	//public Transform test;
	//public Vector3 start;
	//public float cardOffset;
	public GameObject cardPrefab;

	void Start ()
	{
		fetchedCards = new Dictionary<int,CardView>();
		deck = GetComponent<Deck>();
		ShowCards();
		lastCount = deck.CardCount; 

		deck.CardRemoved += deck_CardRemoved;
		deck.CardAdded += deck_CardAdded;
	}


	void deck_CardAdded(object sender, CardEventArgs e)
    {
		Vector3 temp = transform.TransformPoint(0,0,0);
        AddCard(temp, e.CardIndex, deck.CardCount);
    }

	void deck_CardRemoved (object sender, CardEventArgs e)
	{
		if (fetchedCards.ContainsKey (e.CardIndex)) 
		{
			Destroy(fetchedCards[e.CardIndex].Card);
			fetchedCards.Remove(e.CardIndex);
		}
	}

	void Update ()
	{
		if (lastCount != deck.CardCount) {
			lastCount = deck.CardCount;
			ShowCards();

		}
	}

	void reloadCard ()
	{
			
	}


	void ShowCards ()
	{

		int cardCount = 0;
		if (deck.HasCards) 
		{
			foreach (int i in deck.GetCards()) 
			{
				//float co = cardOffset * cardCount;

				//Vector3 temp = start + new Vector3 (0f, 0f, 0f);
				Vector3 temp = transform.TransformPoint(0,0,0);
				//Instantiate(cardPrefab,temp,cardPrefab.transform.rotation);
				AddCard (temp, i, cardCount);
				cardCount++;



			}
		}
	}

	void AddCard (Vector3 position, int cardIndex, int positionalIndex)
	{
		if (fetchedCards.ContainsKey(cardIndex))
		{
			return;	
		}



		GameObject cardCopy = (GameObject)Instantiate(cardPrefab);
		cardCopy.transform.position = position;
		//cardCopy = test.gameObject.transform.GetChild(0).GetChild(0).gameObject;

		CardModel cardModel = cardCopy.GetComponent<CardModel>();
		cardModel.cardIndex = cardIndex;
		cardModel.ToggleCard(true);

		SpriteRenderer spriteRenderer = cardCopy.GetComponent<SpriteRenderer>();
		spriteRenderer.sortingOrder = positionalIndex;

		fetchedCards.Add(cardIndex,new CardView(cardCopy));

		//Debug.Log("Hand Value = " + deck.HandValue());
	}

}
