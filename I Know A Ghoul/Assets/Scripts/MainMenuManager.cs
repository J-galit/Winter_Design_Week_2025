using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{

    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject creditsPanel;

    public void loadMainGame()
    {

        SceneManager.LoadScene("EnchantedForest");

    }

    public void showCredits()
    {

        menuPanel.SetActive(false);
        creditsPanel.SetActive(true);

    }

    public void hideCredits()
    {

        menuPanel.SetActive(true);
        creditsPanel.SetActive(false);

    }

}
