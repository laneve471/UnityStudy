using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example03 : MonoBehaviour
{
    // Start is called before the first frame update

    // private const int PlayerIdle = 10;

    enum PlayerState { Idle, Move, Attack }

    void Awake()
    {
        PlayerState playerState = PlayerState.Idle;

        switch(playerState)
        {
            case PlayerState.Idle:
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerState.Move:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerState.Attack:
                Debug.Log("플레이어 상태 : 공격");
                break;
        }

        /* 상수 사용 버전
        const int playerIdle = 0;
        const int playerMove = 1;
        const int playerAttack = 2;

        int playerState = playerIdle;

        switch(playerState)
        {
            case playerIdle:
                Debug.Log("플레이어 상태 : 대기");
                break;
            case playerMove:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case playerAttack:
                Debug.Log("플레이어 상태 : 공격");
                break;
        }*/

        // nullable
/*        int? intValue01 = null;
        float? floatValue01 = null;
        double? doubleValue01 = null;*/


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
