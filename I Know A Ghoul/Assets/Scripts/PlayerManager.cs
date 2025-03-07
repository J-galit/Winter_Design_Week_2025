using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class PlayerManager : MonoBehaviour
{

    DialogueRunner diagRunner;

    [SerializeField] bool hasThing;
    [SerializeField] bool visitSpot;
    [SerializeField] bool talkedToBouncer;
    [SerializeField] bool talkedToBartender;
    [SerializeField] bool talkedToPhotographer;
    [SerializeField] bool hasSignature;
    [SerializeField] bool hasDrink;
    [SerializeField] bool canTalkToMillie;
    
    [SerializeField] bool gameOver;

    public bool almostDone;

    // Start is called before the first frame update
    void Awake()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();
        diagRunner.AddFunction<bool>("get_player_has_thing", getHasThing);

        diagRunner.AddFunction<bool>("did_player_visit_spot", getDidPlayerVisitSpot);
        diagRunner.AddFunction<bool>("visitedSpot", visitedSpot);


        diagRunner.AddFunction<bool>("getTalkedToBouncer", getTalkedToBouncer);
        diagRunner.AddFunction<bool>("TalkedToBouncer", TalkedToBouncer);

        diagRunner.AddFunction<bool>("getTalkedToBartender", getTalkedToBartender);
        diagRunner.AddFunction<bool>("TalkedToBartender", TalkedToBartender);
        diagRunner.AddFunction<bool>("HasSignature", getHasSignature);
        diagRunner.AddFunction<bool>("giveSignature", giveSignature);

        diagRunner.AddFunction<bool>("HasPinkDrink", getHasPinkDrink);
        diagRunner.AddFunction<bool>("givePinkDrink", givePinkDrink);

        diagRunner.AddFunction<bool>("getTalkedToPhotographer", getTalkedToPhotographer);
        diagRunner.AddFunction<bool>("TalkedToPhotographer", TalkedToPhotographer);

        diagRunner.AddFunction<bool>("getCanTalkToMillie", getCanTalkToMillie);
        diagRunner.AddFunction<bool>("CanTalkToMillie", CanTalkToMillie);

        diagRunner.AddFunction<bool>("isGameOver", getGameOver);
        diagRunner.AddFunction<bool>("TheGameIsOver", TheGameIsOver);

        diagRunner.AddFunction<bool>("almostDone", getAlmostDone);
        diagRunner.AddFunction<bool>("SetAlmostDone", SetAlmostDone);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true)
        {
            SceneManager.LoadScene("EndScene");
        }
    }


    //Photographer Functions
    public bool getDidPlayerVisitSpot()
    {
        return visitSpot;
    }

    public bool visitedSpot()
    {
        visitSpot = true;
        return true;
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

    //Bartender Functions

    public bool getTalkedToBartender()
    {
        return talkedToBartender;
    }

    public bool TalkedToBartender()
    {
        talkedToBartender = true;
        return true;
    }

    public bool getHasSignature()
    {
        return hasSignature;
    }

    public bool giveSignature()
    {
        hasSignature = true;
        return true;
    }
    [YarnCommand("HasPinkDrink")]
    public bool getHasPinkDrink()
    {
        return hasDrink;
    }

    public bool givePinkDrink()
    {
        hasDrink = true;
        return true;
    }



    //Photographer Functions
    public bool getTalkedToPhotographer()
    {
        return talkedToPhotographer;
    }

    public bool TalkedToPhotographer()
    {
        talkedToPhotographer = true;
        return true;
    }

    //Millie Functions
    public bool getCanTalkToMillie()
    {
        return canTalkToMillie;
    }

    public bool CanTalkToMillie()
    {
        canTalkToMillie = true;
        return true;
    }

    //Gameover Script

    public bool getAlmostDone()
    {
        return almostDone;
    }
    [YarnCommand("SetAlmostDone")]
    public bool SetAlmostDone()
    {
        almostDone = true;
        return true;
    }


    public bool getGameOver()
    {

        return gameOver;
    }

    [YarnCommand("TheGameIsOver")]
    public bool TheGameIsOver()
    {
        gameOver = true;
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
