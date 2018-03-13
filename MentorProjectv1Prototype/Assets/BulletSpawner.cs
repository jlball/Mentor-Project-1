using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour {

    public GameObject bullet;

	
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
	}
}
