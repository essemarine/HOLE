using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectibleCollected(float objectSize)
    {
        //Debug.Log("Increase the size by : " + objectSize);
        transform.localScale += objectSize * Vector3.one;
    }
}
