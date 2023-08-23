using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Paddle : MonoBehaviour
{
    public float verticalMovementSpeed;
    public float maxYPosition;
    public KeyCode upKey;
    public KeyCode downKey;
    public int ballHitXDirection;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < maxYPosition)
        {
            MoveUp();
        }
        else if (Input.GetKey(downKey) && transform.position.y > -maxYPosition)
        {
            MoveDown();
        }
    }

    public void MoveUp()
    {
        transform.position += Vector3.up * verticalMovementSpeed * Time.deltaTime;  //time.delta time makes things run at the same speed regardless of processing power
    }

    public void MoveDown()
    {
        transform.position += Vector3.down * verticalMovementSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
