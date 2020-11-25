using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = respawnPoint.transform.position;
        player.GetComponent<CharacterController>().enabled = true;
        //  Debug.Log(player.transform.position);
        //  Debug.Log(respawnPoint.transform.position);
    }
    
}
