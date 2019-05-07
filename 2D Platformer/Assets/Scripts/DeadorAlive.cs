using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadorAlive : MonoBehaviour
{
	int Lives;
    // Start is called before the first frame update
    void Start()
    {
		Lives = 5;
    }
	public void IsAlive()
	{
		while (Lives > 0)
		{
			Debug.Log("You areth alive");
		}
		if(Lives == 0 && Lives < 0)
		{
			Debug.Log("You are already dead");
		}
	}
    // Update is called once per frame
    void Update()
    {
	
    }
}
