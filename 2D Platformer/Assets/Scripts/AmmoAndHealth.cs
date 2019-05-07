using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmmoAndHealth : MonoBehaviour
{
    int[] MissleArray;
    int[] healthArray;
    private int Health;
	private int Missle;
	private bool Alive;
	DeadorAlive doa;
    // Start is called before the first frame update
    void Start()
    {
		Health = 99;
		Missle = 15;
	}
    public void PermHealthMissleIncrease()
    {
		Health = (healthArray.Length * 100) + 99;
		Missle = (MissleArray.Length * 5) + 15;
	}
    // Update is called once per frame
    void Update()
    {	
		if (Health < 0)
		{
			Debug.Log("beep");
		}
		//doa.IsAlive();
		//PermHealthMissleIncrease();
		Debug.Log(MissleArray);
		Debug.Log(healthArray);
    }
	void OnGUI()
	{
		GUI.Box(new Rect(15, 10, 80, 25), "Energy: " + Health);
		GUI.Box(new Rect(150, 10, 80, 20), "Missles: " + Missle);


		{
			print("Krijg de teefus");
		}
	}
}



