using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class PlayerManager : MonoBehaviour
{

    DialogueRunner diagRunner;

    [SerializeField] bool hasThing;
    [SerializeField] bool visitSpot;
    [SerializeField] bool talkedToBouncer;

    // Start is called before the first frame update
    void Awake()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();
        diagRunner.AddFunction<bool>("get_player_has_thing", getHasThing);
        diagRunner.AddFunction<bool>("did_player_visit_spot", getDidPlayerVisitSpot);
        diagRunner.AddFunction<bool>("getTalkedToBouncer", getTalkedToBouncer);
        diagRunner.AddFunction<bool>("TalkedToBouncer", TalkedToBouncer);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Photographer Functions
    public bool getDidPlayerVisitSpot()
    {
        return visitSpot;
    }

    //Bouncer Functions
    public bool getTalkedToBouncer()
    {
        return talkedToBouncer;
    }

    public bool TalkedToBouncer()
    {
        talkedToBouncer = true;
        return true;
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
