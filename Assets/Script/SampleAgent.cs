using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SampleAgent : MonoBehaviour {
	[SerializeField]
	public Transform target;
	NavMeshAgent agent;
	public GameObject[] queryChan;
	public DebugPlayer player;
	[SerializeField]
	QuerySDMecanimController.QueryChanSDAnimationType defaultAnimType = QuerySDMecanimController.QueryChanSDAnimationType.NORMAL_STAND;
	int index;

	// Use this for initialization
	void Start ()
	{
		agent = this.GetComponent<NavMeshAgent> ();

		if (agent == null) {
			Debug.LogError ("The nav mesh agent component is not attached to" + gameObject.name);
		}

	}

	void Update(){
		
		if(player.isAttack == true && player.isDefend == false){
			//Debug.Log("I'm Here");
			ChangeAnimation(2);
			SetDestination();
		}else if(player.isAttack == false && player.isDefend == true)
		{
			ChangeAnimation(10);
			agent.ResetPath();
		}

	}

	private void SetDestination()
	{

		Vector3 targetVector = target.transform.position;
		agent.SetDestination(targetVector);

	}

	void ChangeAnimation (int animNumber)
	{
		queryChan[index].GetComponent<QuerySDMecanimController>().ChangeAnimation((QuerySDMecanimController.QueryChanSDAnimationType)animNumber);
	}
}
