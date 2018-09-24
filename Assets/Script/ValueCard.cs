using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueCard : MonoBehaviour {

	
	public Text t;
	public DebugPlayer value;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

		if(value.isAttack == true && value.isDefend == false)
		{
			int Attackvalue = value.AttackPoint;
			Debug.Log(Attackvalue);	
			t.text = Attackvalue.ToString();
		}else if(value.isDefend == true && value.isAttack == false)
		{
			int Defendvalue = value.DefendPoint;
			Debug.Log(Defendvalue);	
			t.text = Defendvalue.ToString();
		}
	}
}
