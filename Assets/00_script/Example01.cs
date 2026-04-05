using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 클래스 상속
// MonoBehaviour : 유니티에서 제공하는 클래스, MonoBehaviour 클래스를 상속받으면 유니티에서 제공하는 다양한 기능을 사용할 수 있다.
public class Example01 : MonoBehaviour
{
    private void Awake() // 기본적으로 접근 지정자 private
    {
        Debug.Log("Awake: 오브젝트가 생성된다"); // 씬에 생성
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable: 오브젝트가 활성화될 때 실행된다");
        // UI 창이 켜질 때, 버튼 상태 갱신될 때, 아이템이 리스폰될 때, 효과음 재생될 때
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable: 오브젝트가 비활성화될 때 실행된다");
        // UI 창이 꺼질 때, 아이템이 사라질 때, 효과음이 꺼질 때, 이펙트가 꺼질 때
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy: 오브젝트가 삭제될 때 실행");
        // 플레이어가 사망 -> 결과값
        // 적을 제거 -> 아이템 드롭 
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start: 초기화가 시작되고 최초 1회 생성된다");
        // 게임 시작할 때 한 번만 실행 -> 이후 업데이트
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update: 매 프레임마다 작동 계속해서 업데이트가 된다");
        // 게임이 실행되고 있을 때 항상 계속해서 업데이트가 됨. 키보드 입력, 마우스 입력...
        // 컴퓨터 사양에 따라 달라짐
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate: 프레임 속도와 상관없이 일정 간격으로 실행됨");
        // 물리연산 주기마다 실행
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate: update 함수가 끝나고 나서 실행된다");
        // 카메라 추적할 때, 
    }
}
