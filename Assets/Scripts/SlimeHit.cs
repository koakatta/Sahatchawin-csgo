 using UnityEngine;
 using System.Collections;
 
 public class SlimeHit : MonoBehaviour 
 {
    public GameObject Slime1;
    public GameObject Slime2;

     void OnMouseDown()
     {
         Slime1.SetActive(false);
         Slime2.SetActive(false);

         Vector3 position = gameObject.transform.position;
        
         Destroy(gameObject);

         Slime1.transform.position = position;
         Slime2.transform.position = position;

         Slime1.SetActive(true);
         Slime2.SetActive(true);
     }
 }