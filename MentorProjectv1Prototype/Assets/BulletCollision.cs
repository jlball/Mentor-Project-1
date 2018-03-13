using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

    public float health = 100;
    public GameObject parent;
    public int soldiersIndex;
    public SpawnSoldiers spawnSoldiers;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Bullet(Clone)")
        {
            health = health - 25.0f;
            Destroy(other.gameObject);
        }
        if (health <= 0.0f)
        {
            spawnSoldiers.soldiers.Remove(parent);
            Destroy(parent);
        }
    }
}
