using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {
    CameraRaycaster camerRayCaster;
	// Use this for initialization
	void Start () {
        camerRayCaster = GetComponentInChildren<CameraRaycaster>();

    }
	
	// Update is called once per frame
	void Update () {
        print(camerRayCaster.layerHit);
	}
}
