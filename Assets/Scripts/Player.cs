using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1;
    
    private KeyCode up = KeyCode.UpArrow;
    private KeyCode down = KeyCode.DownArrow;
    private KeyCode right = KeyCode.RightArrow;
    private KeyCode left = KeyCode.LeftArrow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        if (Input.GetKey(down))
        {
            transform.position += Vector3.back*Time.deltaTime * speed;
        }
        
        if (Input.GetKey(up))
        {
            transform.position += Vector3.forward*Time.deltaTime * speed;
        }
        
        if (Input.GetKey(left))
        {
            transform.position += Vector3.left*Time.deltaTime * speed;
        }
        
        if (Input.GetKey(right))
        {
            transform.position += Vector3.right*Time.deltaTime * speed;
        }
    }
}
