using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (CameraRaycaster))]
public class CursorAffordance: MonoBehaviour {
    [SerializeField] Texture2D walkCursor, targetCursor, unknownCursor = null;
    [SerializeField] Vector2 cursorHotspot = new Vector2(0,0);
    CameraRaycaster camerRayCaster;
	// Use this for initialization
	void Start () {
        camerRayCaster = GetComponentInChildren<CameraRaycaster>();

    }
	
	// Update is called once per frame
	void LateUpdate () {

        switch (camerRayCaster.currentLayerHit)
        {
            case Layer.Walkable:
                Cursor.SetCursor(walkCursor, cursorHotspot, CursorMode.Auto);
                break;
            case Layer.Enemy:
                Cursor.SetCursor(targetCursor, cursorHotspot, CursorMode.Auto);
                break;
            case Layer.RaycastEndStop:
                Cursor.SetCursor(unknownCursor, cursorHotspot, CursorMode.Auto);
                break;
            default:
                Debug.Log("dont konw what cursor to show");
                return;

        }
       
	}
}
