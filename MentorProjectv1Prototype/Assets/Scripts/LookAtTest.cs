using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTest : MonoBehaviour {


    public SpawnSoldiers spawnSoldiers;
    private List<float> distances;
    private float distance = 0.0f;
    private float minDistance;
    public GameObject closeSoldier;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(spawnSoldiers.soldiers.Count > 0)
        {
            minDistance = Vector3.Distance(transform.position, spawnSoldiers.soldiers[0].transform.position);
            closeSoldier = spawnSoldiers.soldiers[0];

            for (int i = 0; i < spawnSoldiers.soldiers.Count; i++)
            {
                distance = Vector3.Distance(transform.position, spawnSoldiers.soldiers[i].transform.position);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closeSoldier = spawnSoldiers.soldiers[i];
                }
            }

            transform.LookAt(closeSoldier.transform.GetChild(0));
        }
	}


}
