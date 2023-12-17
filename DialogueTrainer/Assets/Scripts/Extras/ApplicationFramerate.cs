using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationFramerate : MonoBehaviour
{
    public int framerate;
    private void Awake()
    {
        Application.targetFrameRate = framerate;
    }
}
