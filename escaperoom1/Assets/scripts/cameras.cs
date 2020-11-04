using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameras : MonoBehaviour
{
    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();
    public Text cam1, cam2;
    void Start()
    {
        keys.Add("cam1", KeyCode.C);
        keys.Add("cam2", KeyCode.V);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
