using UnityEngine;
using System.Collections;

public class UnitMovement : MonoBehaviour {

    public Transform target;
    private float Speed = 2f;
    private Vector3 rotateSpeed = Vector3.down * 50f;

    Transform player;
    NavMeshAgent nav;

    // Use this for initialization
    void Start () {

        player = GameObject.FindGameObjectWithTag("Player2").transform;
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

        CastleMovement();
        //nav.SetDestination(player.position);

        //Find Castle then movetowards it this should always be overridden by closest unit
       // Movement();

	}
    void CastleMovement()
    {



        //This needs to be edited so that it rotates until it faces a certain target
        //transform.Rotate(rotateSpeed * Time.deltaTime);

        Vector3 targetDir = target.position - transform.position;
        float step = Speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
        Debug.DrawRay(transform.position, newDir, Color.red);
        transform.rotation = Quaternion.LookRotation(newDir);


        transform.position = Vector3.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);

    }

}
