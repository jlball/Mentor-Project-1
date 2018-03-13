using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSoldiers : MonoBehaviour {

    public GameObject soldierPrefab;
    [SerializeField]
    public List<GameObject> soldiers;
    private RaycastHit hit;
    private int i = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray.GetPoint(0.0f), ray.direction, out hit))
            {
                SpawnSolider(hit.point);
            }
        }

        for (int i = 0; i < soldiers.Count; i++)
        {
            if(soldiers[i] == null)
            {

            }
        }
	}

    void SpawnSolider(Vector3 spawnPosition)
    {
        GameObject soldier = Instantiate(soldierPrefab, spawnPosition, Quaternion.identity);

        soldier.GetComponentInChildren<BulletCollision>().soldiersIndex = i;
        i++;

        soldier.GetComponentInChildren<BulletCollision>().spawnSoldiers = GetComponent<SpawnSoldiers>();

        soldiers.Add(soldier);
    }
}
