using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Yarn.Unity;

public class GameManager : MonoBehaviour
{

    DialogueRunner diagRunner;
    string userInput = "";
    //InputField is a Unity/TMP thing that manages the input of text
    //The text underneath it is doing a bunch of stuff that we may not understand
    //We can access the text value of the input field by using:
    //TMP_InputField rather than TMP_Text - Keely Brown
    public TMPro.TMP_InputField textField;
    [SerializeField] GameObject textBox;

    bool continueButtonPressed = false;

    public InMemoryVariableStorage varStorage;


    // Start is called before the first frame update
    void Awake()
    {

        diagRunner = GameObject.FindObjectOfType<DialogueRunner>();
        diagRunner.AddFunction<string>("get_player_input", getUserInput);

    }

    public void SpeakToBox()
    {

        diagRunner.StartDialogue("BoxScript");

    }

    [YarnCommand("user_text_prompt")]
    public IEnumerator userInputPrompt()
    {
        Debug.Log("enter coroutine");
        textBox.SetActive(true);

        yield return new WaitUntil(() => continueButtonPressed == true);

        Debug.Log("Size of text["+textField.text.Length.ToString()+"]");
        if (textField.text.ToString() != "")
        {
            Debug.Log("second if accessed");
            userInput = textField.text.ToString().ToLower();
            textField.text = null;
            textBox.SetActive(false);
            continueButtonPressed = false;
            yield return null;

        }
        
        Debug.Log("end of coroutine");
    }

    public string getUserInput()
    {

        Debug.Log("userInput is " + userInput);
        return userInput;

    }

    public void setContinueTrue()
    {

        continueButtonPressed = true;

    }

}
