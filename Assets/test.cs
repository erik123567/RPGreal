using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public GameObject playerObject;
    public float cameraOffset = 5.0F;

    void Update()
    {

        Vector3 cameraPosition = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y, playerObject.transform.position.z + cameraOffset);
        GetComponent<Camera>().transform.position = cameraPosition;
    }
}
