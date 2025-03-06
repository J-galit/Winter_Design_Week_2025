using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class PhotographerScript : MonoBehaviour
{
    DialogueRunner diagRunner;

    bool spokenToPlayer;

    // Start is called before the first frame update
    void Awake()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();
        diagRunner.AddFunction<bool>("get_spoken_to_playerP", getSpokenToPlayerP);
        diagRunner.AddFunction<bool>("flag_box_as_player_spokenP", flagAsSpokenToPlayerP);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool getSpokenToPlayerP()
    {

        return spokenToPlayer;

    }

    [YarnCommand("flag_box_as_player_spokenP")]
    public bool flagAsSpokenToPlayerP()
    {

        spokenToPlayer = true;
        Debug.Log("The box has spoken to the player.");

        return true;

    }
}
