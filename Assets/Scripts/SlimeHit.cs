 using UnityEngine;
 using System.Collections;
 
 public class SlimeHit : MonoBehaviour 
 {
    public Transform Slime1;
    public Transform Slime2;

     void OnMouseDown()
     {
         Vector3 position = gameObject.transform.position;
        
         Destroy(gameObject);

         Slime1.position = position;
         Slime2.position = position;
     }
 }