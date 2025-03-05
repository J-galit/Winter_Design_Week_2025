using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Yarn.Unity;

public class GameManager : MonoBehaviour
{

    DialogueRunner diagRunner;
    string userInput = "";
    public TextMeshProUGUI textField;
    [SerializeField] GameObject textBox;

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

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) == true);

        if (textField.text.ToString() != "")
        {
            Debug.Log("second if accessed");
            userInput = textField.text.ToString().ToLower();
            textField.text = null;
            textBox.SetActive(false);
            yield return null;

        }
        
        Debug.Log("end of coroutine");
    }

    public string getUserInput()
    {

        Debug.Log("userInput is " + userInput);
        return userInput;

    }

}
