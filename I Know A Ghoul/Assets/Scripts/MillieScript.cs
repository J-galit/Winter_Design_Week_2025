using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MillieScript : MonoBehaviour
{

    public GameObject player;
    public PlayerManager playerManager;
    public Transform teleportPoint;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (playerManager.getAlmostDone())
        {
            transform.position = teleportPoint.position;
            transform.rotation = teleportPoint.rotation;
        }
    }
}
