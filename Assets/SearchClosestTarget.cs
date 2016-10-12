using UnityEngine;
using System.Collections;

public class SearchClosestTarget : MonoBehaviour {
    float radius;
    public Vector3 center;
    bool lockedOn;
	// Use this for initialization
	void Start () {
        lockedOn = false;
        radius = 20f;
	}
	
	// Update is called once per frame
	void Update () {
        center = this.transform.position;
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);

        if (hitColliders.Length == 3 && (lockedOn == false))
        {
            //Grow in size
            this.transform.localScale = new Vector3(12, 12, 12);

            UnitMovement unitmovement = this.GetComponent<UnitMovement>();
            Debug.Log(hitColliders[1].transform);
            unitmovement.ChangeTarget(hitColliders[1].transform);
            Debug.Log("Attacking nearest bear");
            lockedOn = true;
        }

       // Debug.Log(hitColliders.Length);
    }
}
