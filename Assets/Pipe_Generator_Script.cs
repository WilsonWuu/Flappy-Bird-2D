using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Generator_Script : MonoBehaviour
{
    public GameObject pipe;
    public float generateRate = 3;
    public float timer = 0;
    public float heightOffeset = 50;
    // Start is called before the first frame update
    void Start()
    {
        pipegenerate();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < generateRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            pipegenerate();
            timer = 0;
        }
    }

    void pipegenerate()
    {
        float lowestPoint = transform.position.y - heightOffeset;
        float highestPoint = transform.position.y + heightOffeset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
