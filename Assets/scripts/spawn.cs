using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;
using UnityEngine.UIElements;

public class spawn : MonoBehaviour
{
    public GameObject prefab;
    public float Spawncooldown = 1f;
    private float t;

    // Start is called before the first frame update
    void Start()
    {
        t += Time.deltaTime;
        if (t > Spawncooldown)
        {
            t = 0f;
            spawnag();
        }
    }

    // Update is called once per frame
    private void spawnag()
    {
        GameObject newGO = Instantiate(prefab, transform.position, Quaternion.identity);

    }
}