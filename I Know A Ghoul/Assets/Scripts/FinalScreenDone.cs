using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScreenDone : MonoBehaviour
{

    public void loadMainGame()
    {
        print("Button");
        SceneManager.LoadScene("MenuScene");

    }
  
}
