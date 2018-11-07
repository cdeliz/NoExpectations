using UnityEngine;
using System.Collections;
using System;

public class DayClock : MonoBehaviour
{

    public float dayLength = 12.0f;	//minutes
    public int startTime = 10;	//start of day
    float elapsedTime;

	public string ReturnTime()
	{
		int elapsedHours = startTime+(int)elapsedTime/60;
		int elapsedMins = ((int)elapsedTime)%60;
	    return ReturnFormattedTime(elapsedHours) + ":" + ReturnFormattedTime(elapsedMins);
    }

    private string ReturnFormattedTime(int time)
    {
        if(time < 10)
        {
            return "0" + time.ToString();
        }
        return time.ToString();
    }

    public void DrawCurrentTime()
    {
        GUI.Label(new Rect(10, 10, 100, 20), ReturnTime());
    }

    private void OnGUI()
    {
        DrawCurrentTime();
    }

    void FixedUpdate()
    {
        elapsedTime += Time.deltaTime;
    }

}