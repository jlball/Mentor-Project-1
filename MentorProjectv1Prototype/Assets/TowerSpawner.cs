using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour {

    public GameObject towerSpawner;
    public SpawnSoldiers spawnSoliders;
    private RaycastHit hit;


	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray.GetPoint(0.0f), ray.direction, out hit))
            {
                SpawnTower(hit.point);
            }
        }
	}

    void SpawnTower(Vector3 spawnPosition)
    {
        GameObject Tower = Instantiate(towerSpawner, spawnPosition, Quaternion.identity);
        Tower.GetComponentInChildren<LookAtTest>().spawnSoldiers = spawnSoliders;
    }
}
