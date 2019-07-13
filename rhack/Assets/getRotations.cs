using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getRotations : MonoBehaviour
{   public GameObject temp_object_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(temp_object_1.GetComponent<Transform>().rotation.y);
    }
}
