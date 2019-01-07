using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMoving : MonoBehaviour {

    public GameObject Origin;
    public GameObject Destination;
    public static bool UIUpdateMarker;

    public void OnMouseDown()
    {
    	UIUpdateMarker = true;

//        Origin.transform.position = new Vector3(1.0f, 1.0f);
//        Destination.transform.position = new Vector3(0.0f, 0.0f);
    }

    private void Update()
    {
    	if (UIUpdateMarker == true)
    	{
    	Origin.SetActive(false);
    	Destination.SetActive(true);
    	UIUpdateMarker = false;
    	}
    }
}
