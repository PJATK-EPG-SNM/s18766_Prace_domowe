using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacja_zrzut : MonoBehaviour
{
    private bool Dotyka;
    void Update () {
      if(Dotyka == true)
        {
         transform.Rotate(Vector3.forward * 1);
        }
 }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Dotyka = true;
    }
}
