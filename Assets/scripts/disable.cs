using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject object1 = this.gameObject;
        object1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
