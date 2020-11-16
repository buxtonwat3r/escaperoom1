using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameras : MonoBehaviour
{
    public GameObject cam1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;

    void Update()
    {
        if (Input.GetButtonDown("1Key"))
        {
            cam1.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
        }
        if (Input.GetButtonDown("2Key"))
        {
            cam1.SetActive(false);
            camera2.SetActive(true);
            camera3.SetActive(false);
            camera4.SetActive(false);
        }
        if (Input.GetButtonDown("3Key"))
        {
            cam1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);
            camera4.SetActive(false);
        }
        if (Input.GetButtonDown("4Key"))
        {
            cam1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(true);
        }
    }
} 
