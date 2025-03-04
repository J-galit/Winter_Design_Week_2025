using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class GameManager : MonoBehaviour
{

    DialogueRunner diagRunner;

    // Start is called before the first frame update
    void Start()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpeakToBox()
    {

        diagRunner.StartDialogue("BoxScript");

    }

}
