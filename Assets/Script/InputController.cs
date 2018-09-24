using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(SwipeManager))]
public class InputController : MonoBehaviour
{
public GameObject handle; // Perhaps your playerscript?
GameController fight;

void Start()
{
SwipeManager swipeManager = GetComponent<SwipeManager>();
swipeManager.onSwipe += HandleSwipe;
swipeManager.onLongPress += HandleLongPress;
}

void HandleSwipe(SwipeAction swipeAction)
{
//Debug.LogFormat("HandleSwipe: {0}", swipeAction);
		if(swipeAction.direction == SwipeDirection.Up || swipeAction.direction == SwipeDirection.UpRight)
{
// move up

Debug.Log("Up");
}
else if (swipeAction.direction == SwipeDirection.Right || swipeAction.direction == SwipeDirection.DownRight)
{
// move right

}
else if (swipeAction.direction == SwipeDirection.Down || swipeAction.direction == SwipeDirection.DownLeft)
{
// move down

}
else if (swipeAction.direction == SwipeDirection.Left || swipeAction.direction == SwipeDirection.UpLeft)
{
// move left

}
}

void HandleLongPress(SwipeAction swipeAction)
{
//Debug.LogFormat("HandleLongPress: {0}", swipeAction);
}
}