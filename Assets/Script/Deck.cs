using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour {

	List<int> cards;
	public bool GameDeck;
	public int maxCard = 15;
	private int currentCard;


	public bool HasCards {
		get { return cards != null && cards.Count > 0; }
	}

	public event CardEventHandler CardRemoved;
    public event CardEventHandler CardAdded;

	public int CardCount {
		get {
			if (cards == null) 
			{
				return 0;
			} 
			else 
			{
				return cards.Count;
			}
		}
	}

	public IEnumerable<int> GetCards ()
	{
		foreach (int i in cards) 
		{
			yield return i;
		}
	}



	public int Pop ()
	{
		int temp = cards [0];
		cards.RemoveAt (0);

		if (CardRemoved != null) 
		{
			CardRemoved(this, new CardEventArgs(temp));
		}
		currentCard--;

		return temp;
	}

	public void Push (int card)
	{
		cards.Add(card);
		if (CardAdded != null)
        {
            CardAdded(this, new CardEventArgs(card));
        }
	}



	public int HandValue ()
	{
		int cardValue = 0;

		foreach (int card in GetCards()) 
		{
			int cardRank = card % 5;

			cardValue = 3 + cardRank;
		}

		return cardValue;

	}

	public void Shuffle ()
	{
		cards.Clear ();

		for (int i = 0; i < 15; i++) {
			cards.Add (i);
		}


		int count = cards.Count;
		while (count > 1) 
		{
			count--;
			int k = Random.Range(0,count + 1);
			int temp = cards[k];
			cards[k] = cards[count];
			cards[count] = temp;
		}


	}

	void Awake ()
	{


		cards = new List<int> ();
		if (GameDeck) {
			Shuffle ();
		}

	}


}
