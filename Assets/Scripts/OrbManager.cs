using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;

public class OrbManager : MonoBehaviour
{
    public TMP_Text orbCountText;
    public GameObject healingOrb;
    public GameObject freezeOrb;
    public GameObject magicOrb;
    public GameObject magicOrb2;
    public GameObject combininOrbObject;
    public GameObject playerInnerHealingOrb;
    public GameObject playerInnerFreezeOrb;
    public GameObject playerInnerMagicOrb;
    public GameObject playerInnerMagicOrb2;
    public float orbGatherDistance;
    public int orbCount = 4;
    public string sceneName;


    // Update is called once per frame
    void Update()
    {
        orbCountText.SetText(orbCount.ToString());
        if (orbCount <= 0) {
            SceneManager.LoadScene(sceneName);
        }

        float distanceHealingOrb = Vector3.Distance(gameObject.transform.position, healingOrb.transform.position);
        float distanceFreezeOrb = Vector3.Distance(gameObject.transform.position, freezeOrb.transform.position);
        float distanceMagicOrb = Vector3.Distance(gameObject.transform.position, magicOrb.transform.position);
        float distanceMagicOrb2 = Vector3.Distance(gameObject.transform.position, magicOrb2.transform.position);

        if (distanceHealingOrb <= orbGatherDistance)
        {
            healingOrb.transform.position = combininOrbObject.transform.position;
            playerInnerHealingOrb.SetActive(true);
            orbCount--;
        }
        if (distanceFreezeOrb <= orbGatherDistance)
        {
            freezeOrb.transform.position = combininOrbObject.transform.position;
            playerInnerFreezeOrb.SetActive(true);
            orbCount--;
        }
        if (distanceMagicOrb <= orbGatherDistance)
        {
            magicOrb.transform.position = combininOrbObject.transform.position;
            playerInnerMagicOrb.SetActive(true);
            orbCount--;
        }
        if (distanceMagicOrb2 <= orbGatherDistance)
        {
            magicOrb2.transform.position = combininOrbObject.transform.position;
            playerInnerMagicOrb2.SetActive(true);
            orbCount--;
        }
    }
}
