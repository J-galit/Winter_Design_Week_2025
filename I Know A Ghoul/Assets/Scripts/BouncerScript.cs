using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class BouncerScript : MonoBehaviour
{
    DialogueRunner diagRunner;

    bool spokenToPlayer;

    // Start is called before the first frame update
    void Awake()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();
        diagRunner.AddFunction<bool>("get_spoken_to_playerB", getSpokenToPlayer);
        diagRunner.AddFunction<bool>("player_has_spoken_to_Bouncer", flagAsSpokenToPlayer);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool getSpokenToPlayer()
    {

        return spokenToPlayer;

    }

    [YarnCommand("player_has_spoken_to_Bouncer")]
    public bool flagAsSpokenToPlayer()
    {

        spokenToPlayer = true;
        Debug.Log("The box has spoken to the player.");

        return true;

    }
}
