using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Controller : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Introduction"))
        {
            GameManager.beginGame = "Introduction";

        }
    }
}
