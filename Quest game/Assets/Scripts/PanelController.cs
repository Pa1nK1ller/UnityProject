using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject Door;
    public Vector3 DoorPosition;
    public int speed;
    bool opendoor;
    bool stay;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            opendoor = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") {
            stay = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            opendoor = false;
            stay = false;
        }
    }
    private void Update()
    {
        if (opendoor)
        {
            Door.transform.position = Vector3.Lerp(Door.transform.position, DoorPosition, speed * Time.deltaTime);
        }
        if (stay && Input.GetKeyDown(KeyCode.F)) {

            Door.transform.position = Vector3.Lerp(Door.transform.position, DoorPosition, speed * Time.deltaTime);
        }
    }
    private void OnGUI()
    {
        if (stay)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 100), "Нажмите F чтобы использовать");
        }
    }
}
