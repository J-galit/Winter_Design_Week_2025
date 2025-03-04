using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class BoxScript : MonoBehaviour
{

    DialogueRunner diagRunner;

    bool spokenToPlayer;

    // Start is called before the first frame update
    void Start()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();
        diagRunner.AddFunction<bool>("get_spoken_to_player", getSpokenToPlayer);
        diagRunner.AddFunction<bool>("flag_box_as_player_spoken", flagAsSpokenToPlayer);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getSpokenToPlayer()
    {

        return spokenToPlayer;

    }

    public bool flagAsSpokenToPlayer()
    {

        spokenToPlayer = true;
        Debug.Log("The box has spoken to the player.");

        return true;

    }

}
