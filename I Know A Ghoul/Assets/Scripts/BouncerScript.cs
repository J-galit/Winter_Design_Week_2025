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
        diagRunner.AddFunction<bool>("get_spoken_to_playerB", getSpokenToPlayerB);
        diagRunner.AddFunction<bool>("flag_box_as_player_spokenB", flagAsSpokenToPlayerB);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool getSpokenToPlayerB()
    {

        return spokenToPlayer;

    }

    [YarnCommand("flag_box_as_player_spoken")]
    public bool flagAsSpokenToPlayerB()
    {

        spokenToPlayer = true;
        Debug.Log("The box has spoken to the player.");

        return true;

    }
}
