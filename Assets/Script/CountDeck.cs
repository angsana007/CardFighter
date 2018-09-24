using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDeck : MonoBehaviour {

	public Text t;
	public DeckView value;

	void Update () {

		int count = value.lastCount;
		Debug.Log(count);
		t.text = count.ToString();
	}
}
