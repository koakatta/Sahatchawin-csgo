using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyManager : MonoBehaviour
{
    public TMP_Text keyCountText;
    public GameObject eToPickUp;
    public int keyCount = 7;
    public AudioSource pickUp;
    public bool isKeyTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keyCountText.SetText(keyCount.ToString());
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Key")
        {
            Destroy(other.gameObject);
            pickUp.Play();
            keyCount--;
        }
    }
}
