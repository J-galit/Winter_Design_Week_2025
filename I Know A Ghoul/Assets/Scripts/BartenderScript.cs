using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class BartenderScript : MonoBehaviour
{
    DialogueRunner diagRunner;

    bool favouriteDrinkKnown;

    // Start is called before the first frame update
    void Awake()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();
        diagRunner.AddFunction<bool>("isFavouriteDrinkKnown", getFavouriteDrinkKnown);
        diagRunner.AddFunction<bool>("FavouriteDrinkIsKnown", flagAsFavouriteDrink);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool getFavouriteDrinkKnown()
    {

        return favouriteDrinkKnown;

    }

    [YarnCommand("flag_box_as_player_spokenBaretender")]
    public bool flagAsFavouriteDrink()
    {

        favouriteDrinkKnown = true;
        Debug.Log("The box has spoken to the player.");

        return true;

    }
}
