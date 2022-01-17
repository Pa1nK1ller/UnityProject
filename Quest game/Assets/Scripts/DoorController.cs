using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private ObjectType Type;
    public string Description;
    int speed = 1;
    public Vector3 PositionDoor;
    bool keyTrue = false;
    bool open = false;
    bool enter = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player"&& other.TryGetComponent<Inventory>(out var inventory))
        {
            if (inventory.HasObject(Type)) {
                keyTrue = true;
                enter = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        enter = false;
    }
    private void OpenDoor() {
        transform.position = Vector3.Lerp(transform.position, PositionDoor, speed * Time.deltaTime);
    }
    private void Update()
    {
        if (Input.GetKeyDown("f") && keyTrue) {
            open = !open;
        }
        if (open) {
            OpenDoor();
        }
    }
    private void OnGUI()
    { 
        if (enter)
        GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 100), Description);
    }
}
