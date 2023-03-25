using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_pawner : MonoBehaviour
{
    public float maxtime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        if (timer > maxtime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
