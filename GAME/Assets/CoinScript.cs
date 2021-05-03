using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public int rotateSpeed;
    void Start()
    {
        rotateSpeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotateSpeed, 0, Space.World);    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            other.GetComponent<PlayerMovment>().points+=50;
            Destroy(gameObject);
        }
    }
}
