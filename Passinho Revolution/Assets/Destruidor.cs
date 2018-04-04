using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruidor : MonoBehaviour
{
    GameObject passo;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D trig)
    {
        passo = trig.gameObject;
        Destroy(passo);
    }
}
