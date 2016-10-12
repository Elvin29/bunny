using UnityEngine;
using System.Collections;

public class AddReduceMoney : MonoBehaviour {

	public GameObject camera;



	// Use this for initialization
	void Start () {
	
	}


	
	// Update is called once per frame
	void Update () {


		float Time = camera.GetComponent<income> ().timerFunction ();

		if (Time > 1) {
			camera.GetComponent<Money>().addMoney (15);
		}



	}

}




