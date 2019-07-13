using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getRotations : MonoBehaviour
{   public GameObject temp_object_1;
    public GameObject temp_object_2;
    public GameObject temp_object_3;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    bool getCompleteCircles()
    {
        float outer_circle = temp_object_1.GetComponent<Transform>().rotation.y;
        float middle_circle = temp_object_2.GetComponent<Transform>().rotation.y;
        float inner_circle = temp_object_3.GetComponent<Transform>().rotation.y;
        Debug.Log(temp_object_1.GetComponent<Transform>().rotation.y);
        Debug.Log(temp_object_2.GetComponent<Transform>().rotation.y);
        Debug.Log(temp_object_3.GetComponent<Transform>().rotation.y);
        if (outer_circle < 0.1 && outer_circle > -0.1)
        {
            if (middle_circle < 0.1 && outer_circle > -0.1)
            {
                if (inner_circle < 0.1 && outer_circle > -0.1)
                {
                    Debug.Log("I'm Done, hello there");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        getCompleteCircles();
    }
}
