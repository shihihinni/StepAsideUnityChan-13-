using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    GameObject mainCamObj;

    // Start is called before the first frame update
    void Start()
    {
        mainCamObj = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < Camera.main.transform.position.z)
        {
            Destroy (gameObject);
        }
    }

}
