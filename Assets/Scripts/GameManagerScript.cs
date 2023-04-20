using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [Header("Cameras")]
    public GameObject firstPersonCamera;
    public GameObject thirdPersonCamera;
    bool firstPerson;

    [Header("Keybinds")]
    public KeyCode swapCamerasKey = KeyCode.Tab;
    public KeyCode jumpKey = KeyCode.Space;
    public KeyCode sprintKey = KeyCode.LeftShift;
    public KeyCode crouchKey = KeyCode.LeftControl;

    // Start is called before the first frame update
    void Start()
    {
        firstPerson = true;
        firstPersonCamera.SetActive(firstPerson);
        thirdPersonCamera.SetActive(!firstPerson);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(swapCamerasKey))
        {
            if (firstPerson)
            {
                firstPerson = false;
                firstPersonCamera.SetActive(firstPerson);
                thirdPersonCamera.SetActive(!firstPerson);
            }
            else
            {
                firstPerson = true;
                firstPersonCamera.SetActive(firstPerson);
                thirdPersonCamera.SetActive(!firstPerson);
            }
        }
    }
}
