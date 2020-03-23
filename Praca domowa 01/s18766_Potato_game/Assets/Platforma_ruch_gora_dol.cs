using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforma_ruch_gora_dol : MonoBehaviour
{
    float dirY, moveSpeed = 3f;
    bool moveUp = true;

    // Update is called once per frame
    void Update()
    {
    if (transform.position.y > 4f)
    moveUp = false;
    if (transform.position.y < -4f)
    moveUp = true;

    if(moveUp)
    tranform.position = new Vector2(tranform.position.y + moveSpeed * Time.deltaTime, transform.position.x);
    else
    tranform.position = new Vector2(tranform.position.y - moveSpeed * Time.deltaTime, transform.position.x);
    }
}
