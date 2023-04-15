using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SlimeTrap : MonoBehaviour
{
    public UnityEvent onDed;
     void OnMouseDown()
     {
         Destroy(gameObject);
         onDed.Invoke();
     }
}
