using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;

    // Start is called before the first frame update
    void Start()
    {
        Camera1.enabled = true;
        Camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Camera1.enabled = !Camera1.enabled;
            Camera2.enabled = !Camera2.enabled;
        }
    }
    public void CameraSwitchTest()
    {
        Camera1.enabled = !Camera1.enabled;
        Camera2.enabled = !Camera2.enabled;
    }
}
