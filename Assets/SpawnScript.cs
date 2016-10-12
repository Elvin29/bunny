using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    float Timer;
    public GameObject castle1;
    public GameObject castle2;
    public GameObject Unit;
    public RuntimeAnimatorController EnemyAnimatorController;
    public GameObject camera;
    bool recentlySpawned;
    // Use this for initialization
    void Start () {

        recentlySpawned = false;
        
	}


    Transform EnemyFinder()
    {
     
        if (this.gameObject.name == "Castle1") {
            Debug.Log("Fight Castle 2");
            return castle2.transform;
        }
        if (this.gameObject.name == "Castle2")  {
            Debug.Log("Fight Castle 1");
            return castle1.transform;
        }
        return null;

    } 
	// Update is called once per frame
	void Update () {

      

       



        float Time = camera.GetComponent<income>().timerFunction();
        int ConvertedTime = (int)Time;


        if ( (recentlySpawned == false) && ((ConvertedTime+1) % 30 == 0))
        {
            var NewUnit = Instantiate(Unit, transform.position, Quaternion.identity) as GameObject;
            var animator = NewUnit.GetComponent<Animator>().runtimeAnimatorController = EnemyAnimatorController;
            NewUnit.transform.localScale = new Vector3(10, 10, 10);
            NewUnit.AddComponent<Rigidbody>();
            NewUnit.AddComponent<CapsuleCollider>();
            NewUnit.AddComponent<NavMeshAgent>();
            NewUnit.AddComponent<Faction>();
            NewUnit.AddComponent<UnitMovement>().target = EnemyFinder();
            NewUnit.AddComponent<SelectableUnitComponent>();
            NewUnit.AddComponent<SearchClosestTarget>();
            recentlySpawned = true;
        }
        if ((ConvertedTime % 30 == 0) && (recentlySpawned = true))
        {
            recentlySpawned = false;
        }

  
    }
}
