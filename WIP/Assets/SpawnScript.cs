using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    float Timer;
    // Use this for initialization
    void Start () {
    
	}
	    
	// Update is called once per frame
	void Update () {

      

        Timer += Time.deltaTime;
        


        if ((Timer > 15) && (Timer < 16))
        {
            Debug.Log("Create New Unit" + Timer);
            Timer = 0;
           
        }
        
     
    }
}
