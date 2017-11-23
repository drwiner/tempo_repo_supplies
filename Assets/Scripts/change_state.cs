using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_state : MonoBehaviour {
    public bool this_var = false;
    // Use this for initialization
    public float updateInterval = 0.5F;
    private double lastInterval;
    private int frames = 0;
    private float fps;

    void Start()
    {
        lastInterval = Time.realtimeSinceStartup;
        frames = 0;
    }

    // Update is called once per frame
    void Update () {
        ++frames;
        float timeNow = Time.realtimeSinceStartup;
        if (timeNow > lastInterval + updateInterval)
        {
            fps = (float)(frames / (timeNow - lastInterval));
            frames = 0;
            lastInterval = timeNow;
            this_var = true;
        }
    }
}
