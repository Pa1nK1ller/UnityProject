using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoor : MonoBehaviour
{
    private GameObject checkOutRoom;
    public string Tag;
    private void Start()
    {
        checkOutRoom = GameObject.FindGameObjectWithTag(Tag);
    }
    void OnDestroy()
    {
        checkOutRoom.GetComponent<BoxCollider>().enabled = true;
    }
 }
