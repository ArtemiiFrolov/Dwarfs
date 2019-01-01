using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMoving : MonoBehaviour {

    public GameObject Origin;
    public GameObject Destination;

    public void OnMouseDown()
    {
        Origin.transform.position = new Vector3(0.0f, -1.0f);
        Destination.transform.position = new Vector3(0.0f, 0.0f);
    }
}
