using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private bool enter;
    private GameObject checkOutRoom;


    private void Start()
    {
        checkOutRoom = GameObject.FindGameObjectWithTag("CheckOutRoom1");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            enter = false;
        }
    }

    private void OnGUI()
    {
        if (enter)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 100), "Нажмите F чтобы использовать");
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown("f") && enter) {
            checkOutRoom.GetComponent<BoxCollider>().enabled = true;
            Destroy(gameObject);
        }
    }
}
