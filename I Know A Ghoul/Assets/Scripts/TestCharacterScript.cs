using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TestCharacterScript : InteractScript
{

    [SerializeField] string yarnScriptName; //The string for this character/item's Yarn Script.
    Vector3 idleOrientation; //The orientation of the character as it is on startup.
    DialogueRunner diagRunner; //Dialog runner.
    [SerializeField] GameObject player; //The player object.

    Vector3 playerPos; //Used by TurnToPlayer.

    // Start is called before the first frame update
    void Awake()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();
        idleOrientation = transform.localEulerAngles; //Stores start rotation of game object.

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void TalkToMe()
    {

        diagRunner.StartDialogue(yarnScriptName); //Feeds the string given to this character to the dialogue runner. Starts the dialog.

    }

    public override void TurnToPlayer() //Gets the player pos and turns the object to the player.
    {
        
        playerPos = player.transform.position;
        transform.LookAt(playerPos);

    }

    public override void LookAway() //Turns the object back around.
    {

        transform.localEulerAngles = idleOrientation;

    }
}
