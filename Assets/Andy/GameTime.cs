using UnityEngine;
using System.Collections;

// Tracks how much time, in seconds, has passed in the game.
public class GameTime : MonoBehaviour {

    private int dayLength;      // Number of seconds in a single "day" phase.
    private int currentTime;    // Number of seconds since the start of the level.
    private double timeChange;   // Number of seconds since the last time Update() was called.

	// Use this for initialization
	void Start () {

        currentTime = 0;

	}
	
	// Update is called once per frame
	void Update () {

        timeChange += Time.deltaTime;
        if ( timeChange >= 1.0 )
        {
            currentTime += (int)timeChange;
            timeChange = 0.0;
        }
	
	}

    int getCurrentTime()
    {
        return currentTime;
    }
}
