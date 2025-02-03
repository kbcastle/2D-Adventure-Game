using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDictInv : MonoBehaviour
{
    public string objectName;

    public PlayerMovDictInv myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerMovDictInv>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        AddItem();
        Destroy(gameObject);
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
}
