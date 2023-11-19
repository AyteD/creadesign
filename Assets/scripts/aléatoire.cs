using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class aléatoire : MonoBehaviour
{

    float min;
    float max;
    float x;
    float y;
    float z;
    

    // Start is called before the first frame update
    void Start()
    {
        float randomValue = Random.Range(min, max);
    }

    // Update is called once per frame
    void Update()
    {

       
        

        Vector3 position = new Vector3(x, y, z);
    }
}
