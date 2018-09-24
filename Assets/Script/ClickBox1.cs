using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBox1 : MonoBehaviour {

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
            if (EnemyHP.thisHP.Health <= EnemyHP.thisHP.maxHealth)
            {
                EnemyHP.thisHP.Health += 10;
                Debug.Log(EnemyHP.thisHP.Health);
            }
        }

    }
}
