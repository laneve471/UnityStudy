using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    private float moveSpeed = 10.0f;
    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        // 외우고 있을 것
        transform.position = new Vector3(1, 0, 0);
        //transform.rotation = Quaternion.Euler(50, 0, 0);
        //transform.localScale = new Vector3(2, 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(direction, 0, 0) * Time.deltaTime * moveSpeed;
    
        if (transform.position.x > 9.13f)
        {
            //transform. position += new Vector3(-1, 0, 0) * Time.deltaTime * moveSpeed;
            direction = -1;
        }
        else if (transform.position.x < 9.13f)
        {
            //transform.position += new Vector3(1, 0, 0) * Time.deltaTime * moveSpeed;
            direction = 1;
        }
    }
}
