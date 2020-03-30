using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforma2 : MonoBehaviour {
	
	 private Vector3 MovingDirection = Vector3.right;
 
 void Update () {
     gameObject.transform.Translate(MovingDirection * Time.smoothDeltaTime);
         
     if(gameObject.transform.position.x > 2){
         MovingDirection = Vector3.left;
     }else if (gameObject.transform.position.x < -3) {
         MovingDirection = Vector3.right;
     }
 }
}
