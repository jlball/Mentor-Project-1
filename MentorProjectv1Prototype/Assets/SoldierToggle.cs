using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoldierToggle : MonoBehaviour {

    public Toggle toggle;
    public GameObject towerSpawner;

    // Use this for initialization
    void Start()
    {
        toggle.onValueChanged.AddListener(delegate {
            TogglePlacementMode();
        });
    }

    void TogglePlacementMode()
    {
        towerSpawner.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
