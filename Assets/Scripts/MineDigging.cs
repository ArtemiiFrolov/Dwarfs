using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MineDigging : MonoBehaviour {

    public GameObject ButtonMine;
    public GameObject TextForButton;

    public int brakeSeconds = 5;
    public int workingSeconds = 10;
    public static float currentTime;
    public static bool work=true;
    public static bool workStarted=false;

    private float startTime;

    // Use this for initialization
    public void OnMouseDown()
    {
        if (work)
        {
            Resources.Gold += 1;
            if (!workStarted)
            {
                startTime = Time.time;
            }
            workStarted = true;
        }

    }
    private void Start()
    {
        startTime = Time.time;
    }
    private void Update()
    {
        if (workStarted)
        {
            if (work)
            {
                ColorBlock colors = ButtonMine.GetComponent<Button>().colors;
                colors.pressedColor = Color.green;
                ButtonMine.GetComponent<Button>().colors = colors;

                currentTime = workingSeconds - Time.time + startTime;
                if (currentTime < 0)
                {
                    work = false;
                    startTime = Time.time;
                    TextForButton.GetComponent<Text>().text = "Time to rest!";
                }
                
            }
            else
            {
                ColorBlock colors = ButtonMine.GetComponent<Button>().colors;
                colors.pressedColor = Color.red;
                ButtonMine.GetComponent<Button>().colors = colors;

                currentTime = brakeSeconds - Time.time + startTime;
                if (currentTime < 0)
                {
                    work = true;
                    startTime = Time.time;
                    workStarted = false;
                    TextForButton.GetComponent<Text>().text = "Digging!";
                }
                
            }
        }
    }
}
