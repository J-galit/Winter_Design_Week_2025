using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class FriendScript : MonoBehaviour
{
    DialogueRunner diagRunner;

    bool spokenToPlayer = false;

    // Start is called before the first frame update
    void Awake()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();
        diagRunner.AddFunction<bool>("get_spoken_to_playerF", getSpokenToPlayer);
        diagRunner.AddFunction<bool>("player_has_spoken_Friend", flagAsSpokenToPlayer);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool getSpokenToPlayer()
    {

        return spokenToPlayer;

    }

    [YarnCommand("player_has_spoken_Friend")]
    public bool flagAsSpokenToPlayer()
    {

        spokenToPlayer = true;
        Debug.Log("The friend has spoken to the player.");

        return true;

    }
}
