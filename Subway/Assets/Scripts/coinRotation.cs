using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRotation : MonoBehaviour
{
    public GameObject[] allCoins;
    

    // Start is called before the first frame update
    void Start()
    {
            allCoins = GameObject.FindGameObjectsWithTag("coin");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        foreach (GameObject coin in allCoins)
        {
            coin.transform.Rotate(0f, 5f, 0f);
        }
    }

    
}
