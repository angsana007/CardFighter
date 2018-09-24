using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
        	Debug.Log("HP!!");
            if (PlayerHP.thisHP.Health >=0)
            {
                PlayerHP.thisHP.Health -= 10;
                Debug.Log(PlayerHP.thisHP.Health);
            }
        }

    }
}
