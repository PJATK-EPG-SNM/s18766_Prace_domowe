﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforma : MonoBehaviour {
	
	 private Vector3 MovingDirection = Vector3.up;
 
 void Update () {
     gameObject.transform.Translate(MovingDirection * Time.smoothDeltaTime);
         
     if(gameObject.transform.position.y > 0){
         MovingDirection = Vector3.down;
     }else if (gameObject.transform.position.y < -4) {
         MovingDirection = Vector3.up;
     }
 }
}
