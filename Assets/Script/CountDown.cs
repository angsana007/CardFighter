using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	

public class CountDown : MonoBehaviour
{
    public Text t;
    public float n;
	private PlayerHP hp;

    void Update()
    {
        n -= Time.deltaTime;
        t.text = Mathf.Round(n).ToString();

    }
}
