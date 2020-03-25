using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBack : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatSize;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatSize = GameObject.Find("Background").GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPos.x - repeatSize)
        {
            transform.position = startPos; 
        }
    }
}
