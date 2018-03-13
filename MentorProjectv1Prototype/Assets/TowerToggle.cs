using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TowerToggle : MonoBehaviour {

    public Toggle toggle;
    public GameObject soldierSpawner;

	// Use this for initialization
	void Start () {
        toggle.onValueChanged.AddListener(delegate { 
            TogglePlacementMode(); 
        });
	}
	
	void TogglePlacementMode()
    {
        soldierSpawner.SetActive(true);
        this.gameObject.SetActive(false);
        Debug.Log("TOGGLE");
    }
}
