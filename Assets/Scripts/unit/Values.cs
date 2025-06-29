using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Values : MonoBehaviour
{
    public static Canvas canvas
    {
        get
        {
            return GameObject.Find("Canvas").GetComponent<Canvas>();
        }
    }
}
