using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{

    [SerializeField] private ObjectType Type;
    [SerializeField] private string Description;

    public string ObjectDescription => Description;
    public ObjectType ObjectType => Type;
}

public enum ObjectType
{
    KeyRoom1,
    KeyRoom2,
    KeyRoom3,
    Map,
    Fork
}
