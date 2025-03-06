using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class BoardScript : InteractScript
{

    [SerializeField] string yarnScriptName; //The string for this character/item's Yarn Script.
    DialogueRunner diagRunner; //Dialog runner.

    public override void TalkToMe()
    {

        diagRunner.StartDialogue(yarnScriptName);

    }

    public override void TurnToPlayer() //Gets the player pos and turns the object to the player.
    {

        Debug.Log("This object is inanimate.");

    }

    public override void LookAway() //Turns the object back around.
    {

        Debug.Log("This object is inanimate.");

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
