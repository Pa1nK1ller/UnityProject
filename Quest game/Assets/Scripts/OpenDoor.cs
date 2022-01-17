using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    bool enter;
    int speed = 5;
    bool open;
    private void Start()
    {
        Door = GameObject.FindGameObjectWithTag("DoorQestRoom1");
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

        if (other.gameObject.tag == "Player")
        {
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
        if (Input.GetKeyDown("f") && enter)
        {
            open = true;  
        }

        if (open)
        {
            Door.transform.position = Vector3.MoveTowards(Door.transform.position, new Vector3 (5.007f,0.5f,1.1f), speed * Time.deltaTime);
            if (Door.transform.position.z >= 1.1f)
                Destroy(gameObject);
        }
    }
}
