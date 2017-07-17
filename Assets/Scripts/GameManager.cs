using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform[] respawns;
    public GameObject[] agents;

    public float delayTime;

    void Start ()
    {
        StartCoroutine(instancier());
    }

    IEnumerator instancier ()
    {
        while(true)
        {
            Instantiate(agents[Random.Range(0, agents.Length)], respawns[Random.Range(0, respawns.Length)].position, Quaternion.identity);
            yield return new WaitForSeconds(delayTime);
        }
        
    }
}
