using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KayaRaya : MonoBehaviour
{
    public GameObject coin;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("coin") == null)
        {
            coin.SetActive(true);
        }
    }
    
    
}

