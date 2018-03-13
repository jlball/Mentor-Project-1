using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSelect : MonoBehaviour {

    public GameObject TowerSpawner;
    public GameObject SoldierSpawner;
    public static bool isItOn;

	// Use this for initialization
	void Start () {
        Debug.Log("TOGGLE BISH");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("TOGGLE BISH");
	}

    void OnValueChanged()
    {
        Debug.Log("TOGGLE BISH");
    }
}
