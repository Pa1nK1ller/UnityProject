using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    [SerializeField] private GameObject book;
    [SerializeField] private Transform spawnPoint;
    public GameObject Door;
    private bool doorClose;
    private int speed = 1;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorClose = true;
            Instantiate(book, new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z), Quaternion.Euler(0,-90,0));
            GetComponent<BoxCollider>().enabled = false;
        }
    }
    private void Update()
    {
        if (doorClose) {

            Door.transform.position = Vector3.MoveTowards(Door.transform.position, new Vector3(5, 0.5f, 0), speed * Time.deltaTime);
            if (Door.transform.position.z <= 0) {
                Destroy(gameObject);
            }
        }
    }
}
