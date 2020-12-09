using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)   
    {
        if (other.gameObject.tag == "finish")
        {
            mainmenu();
        }
       

    }
    public void mainmenu()

    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("mainmenu");
    }
}
