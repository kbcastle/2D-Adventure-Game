using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDictInv : MonoBehaviour
{
    public string objectName;

    public int objectIndex;

    public PlayerMovDictInv myPlayer;
    public DialogueManager dialogueManager;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerMovDictInv>();
        dialogueManager = FindObjectOfType<DialogueManager>();  
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other) //change to OntriggerStay 2D for the collision to be tracked as long as the player is touching the object
    {
        if (Input.GetKey(KeyCode.Space)) //if colliding with something, player has to press space to actually pick it up
        {
            Interact();
            AddItem();
            Destroy(gameObject);
        }
    }

    public void AddItem()
    {
        if (myPlayer.myInventory.ContainsKey(objectName))
        {
            myPlayer.myInventory[objectName]++;
        }
        else
        {
            myPlayer.myInventory.Add(objectName, 1);
        }
        myPlayer.DisplayInventory();
    }

    public void Interact()
    {
        dialogueManager.currentIndex = objectIndex;  //on collision, set the dialogue index to the number associated with this object
    }
}
