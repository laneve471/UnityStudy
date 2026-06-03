using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private float MoveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MoveDir = Vector3.zero; // Vector3의 값을 (0, 0, 0) 변경
        if (Input.GetMouseButton(0))
        {
            MoveDir += new Vector3(-1, 0, 0);
        }
        if (Input.GetMouseButton(1))
        {
            MoveDir += new Vector3(1, 0, 0);
        }
        

        if (MoveDir != Vector3.zero)
        {
            MoveDir = MoveDir.normalized;

            transform.position += MoveDir * Time.deltaTime * MoveSpeed;
        }
        


        /*// GetAxis를 이용한 조작
        float X = Input.GetAxis("Horizontal");
        float Y = Input.GetAxis("Vertical");
        Vector3 MoveDir = new Vector3(X, Y, 0);

        if (MoveDir != Vector3.zero)
        {
            MoveDir = MoveDir.normalized;
            transform.position = MoveDir * Time.deltaTime * MoveSpeed;
        }*/



        /*// 이동방향을 저장할 Vector3 변수 선언
        Vector3 MoveDir = Vector3.zero; // Vector3의 값을 (0, 0, 0) 변경
        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveDir += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveDir += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MoveDir += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveDir += new Vector3(0, 1, 0);
        }

        if (MoveDir != Vector3.zero)
        {
            MoveDir = MoveDir.normalized;

            transform.position += MoveDir * Time.deltaTime * MoveSpeed;
        }*/

    }
}
