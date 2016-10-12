using UnityEngine;
using System.Collections;

public class Faction : MonoBehaviour {
    public int faction;

    public void factionSelect(int factionThatSpawned)
     {
        faction = factionThatSpawned;
     }


}
