using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PhoneManager : MonoBehaviour
{

    [SerializeField]List<string> obtainedMessages;

    [SerializeField]TextMeshProUGUI phoneText;

    [SerializeField]GameObject phoneAssembly;

    bool phoneActive = false;

    // Start is called before the first frame update
    void Start()
    {

        obtainedMessages.Add("Message 1");
        obtainedMessages.Add("Message 2");
        obtainedMessages.Add("Message 3");
        obtainedMessages.Add("Message 4");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {

            //phoneActive = !phoneActive;

        }

        string displayString = "";

        foreach (string message in obtainedMessages)
        {

            displayString += message + "\n";

        }

        phoneText.text = displayString;

        if (phoneActive)
        {

            phoneAssembly.SetActive(true);

        }
        else
        {

            phoneAssembly.SetActive(false);

        }

    }

    public void AddMessage(string message)
    {

        obtainedMessages.Add(message);

    }

}
