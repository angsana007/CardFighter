using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour {

	private GameObject[] characterList;
	private int index;

	private void Start ()
	{
		index = PlayerPrefs.GetInt("CharacterSelected");
		
		characterList = new GameObject[transform.childCount];

		//Fill the array with my models
		for (int i = 0; i < transform.childCount; i++) {
			characterList [i] = transform.GetChild (i).gameObject;
		}
		//My toggle off their render
		foreach (GameObject go in characterList) {
			go.SetActive (false);
		}

		//My toggle on the selected character
		if (characterList [index]) {
			characterList [index].SetActive (true);
		}	
			
	}


	public void ToggleLeft ()
	{
		//Toggle off the current model
		characterList[index].SetActive(false);
		
		index--;
		if (index < 0) {
			index = characterList.Length - 1;

		}

		//Toggle off the current model
			characterList[index].SetActive(true);
	}


	public void ToggleRight ()
	{
		//Toggle off the current model
		characterList[index].SetActive(false);
		
		index++;
		if (index == characterList.Length) {
			index = 0;

		}

		//Toggle off the current model
			characterList[index].SetActive(true);
	}


	public void ConfirmButtom ()
	{
		PlayerPrefs.SetInt("CharacterSelected", index);
		SceneManager.LoadScene("Game");

	}

}
