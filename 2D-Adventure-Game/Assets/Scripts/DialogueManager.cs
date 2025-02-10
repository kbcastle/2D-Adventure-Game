using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI dialogueDisplay;

    public int currentIndex = 0;

    public string[] dialogue = new string[5];
    // Start is called before the first frame update
    void Start()
    {
        dialogueDisplay.text = dialogue[currentIndex];
    }

    // Update is called once per frame
    void Update()
    {
        dialogueDisplay.text = dialogue[currentIndex];
        if (Input.GetKey(KeyCode.Space)) // press space to reset dialogue box to default (empty)
        {
            currentIndex = 0;
        }
    }
}
