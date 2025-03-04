using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class PlayerManager : MonoBehaviour
{

    DialogueRunner diagRunner;

    [SerializeField] bool hasThing;

    // Start is called before the first frame update
    void Start()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();
        diagRunner.AddFunction<bool>("get_player_has_thing", getHasThing);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getHasThing()
    {

        return hasThing;

    }

    public void giveThing()
    {

        hasThing = true;

    }

}
