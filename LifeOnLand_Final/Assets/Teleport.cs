using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject Player;
    public GameObject teleportation1;
   
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Player.transform.position = teleportation1.transform.position;
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
