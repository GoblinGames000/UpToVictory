using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private void OnDisable()
    {
     GetComponent<SpriteRenderer>().color=Color.white;
     transform.localScale=Vector3.one;
    }
}
