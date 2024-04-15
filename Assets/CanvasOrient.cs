using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CanvasOrient : MonoBehaviour
{
    // Start is called before the first frame update

   
    void Start()
    {
        //GetComponent<Canvas>().worldCamera = Manager.cameraMain;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(Manager.cameraMain.transform.position);
    }
}
