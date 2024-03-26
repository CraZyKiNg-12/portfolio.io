using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset; 

     public GameObject player; 
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(10,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
