using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Labels : MonoBehaviour {

    public GameObject GoldShow;
    public GameObject TimeShow;

	void Update()
    {
        float timer = MineDigging.currentTime;
        GoldShow.GetComponent<Text>().text = "Gold: " + Resources.Gold;
        if (MineDigging.workStarted)
        {
            TimeShow.GetComponent<Text>().text = string.Format("{0}:{1}",
                                                                Mathf.Floor(timer / 60).ToString("00"),
                                                                (timer % 60).ToString("00"));
        } else
        {
            TimeShow.GetComponent<Text>().text = "Ready for work!";
        }
        if (MineDigging.work)
        {
            TimeShow.GetComponent<Text>().color = Color.green;
        }
        else
        {
            TimeShow.GetComponent<Text>().color = Color.red;
        }
    }
}
