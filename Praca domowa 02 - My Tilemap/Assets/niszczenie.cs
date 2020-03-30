using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niszczenie : MonoBehaviour
{
    private bool Dotyka;

    void Update () {
      if(Dotyka == true)
        {
          //  Destroy(gameObject); // Just destroy Gameobject, without delay.

            Destroy(gameObject, 1f); // Destroy GameObject after 5 Seconds.
        }
 }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Dotyka = true;
    }
}
