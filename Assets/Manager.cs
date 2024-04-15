using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static GameObject cameraMain;
    public GameObject _Camera;

    private void Awake()
    {
        cameraMain = _Camera;
    }
}
