using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        int a = 10;
        int b = 3;

        // 산술 연산자
        Debug.Log("a + b = " + (a + b));
        Debug.Log("a - b = " + (a - b));
        Debug.Log("a * b = " + (a * b));
        Debug.Log("a / b = " + (a / b)); // 3
        Debug.Log("a % b = " + (a % b)); // 1

        // 대입 연산자
        int result = a + b;  // 13
        result = result += 5; // 18
        result -= 2; // 16
        result *= 2; // 32

        // 증감 연산자 (++, --) 해당 값에 1을 더하거나 빼기
        a++; // 11
        b--; // 2

        // 비교 연산자 : 두 값이 같은지, 다른지, 큰지, 작은지 등 -> 참/거짓. 숫자로 나오지는 않음
        int x = 10;
        int y = 3;
        int z = 3;

        bool isTrue = x == y; // false
        isTrue = x != y; // true
        isTrue = x > z; // true

        // 논리 연산자
        // && : 둘 다 참이어야만 true
        isTrue = x > 2 && y < 5; // 참 && 참 -> true
        isTrue = x < 2 && y < 5; // 거짓 && 참 -> false

        // !
        isTrue = !isTrue; // 참거짓을 뒤바꿈 => false

        // || : 둘 중 하나라도 참이면 true
        isTrue = x < 2 && y > 5; // 거짓 || 거짓 -> false
        isTrue = x < 2 && y < 5; // 거짓 || 참 -> true

        // 삼항 연산자 : 조건식을 사용해 조건식의 참, 거짓 여부에 따라 다른 결과값을 대입
        // 결과 = 조건식 ? (조건식의 참):(조건식의 거짓)

        int hp = 100;
        int damage = 200;

        string message = (hp - damage) <= 0 ? "캐릭터가 사망했습니다." : "캐릭터의 hp : " + (hp - damage); // 전자 출력
        Debug.Log(message);







        // 조건문
        int A = 10;
        int B = 20;
        int C = B - A; // 10

        // if
        if (A > B) // false
        {
            Debug.Log($"A가 B보다 크다"); // 출력 안 됨
        }
        
        if (A == C) // true
        {
            Debug.Log("A는 C와 같다"); // 출력됨
        }

        int lv = 30;
        int grade = 5;

        if (lv >= 30)
        {
            if (grade >= 5)
            {
                Debug.Log("각성 버튼 출력"); // 출력됨
            }
            else
            {
                Debug.Log("각성 가능 등급이 아님"); // 출력 안 됨
            }
        }
        else
        {
            Debug.Log("레벨업 버튼 출력");
        }

        // if-else 조건문 -> 하나의 케이스만 작동
        if (A > B) // false
        {
            Debug.Log($"A가 B보다 크다"); // 출력 안 됨
        }
        else if (A < B)
        {
            Debug.Log("A가 B보다 작다"); // 출력됨
        }
        else
        {
            Debug.Log("A가 B와 같다"); // 출력 안 됨
        }

        // 조건문 (switch - case)
        int charNum = 1;
        switch (charNum)
        {
            case 1:
                Debug.Log("당신은 전사를 선택했습니다."); // 출력
                break;

            case 2:
                Debug.Log("당신은 마법사를 선택했습니다.");
                break;

            default:
                Debug.Log("전직을 위한 레벨이 부족합니다.");
                break;
        }








        // 반복문 (Loop)
        
        // 1. for문
        // 선언 방식

        for (int i = 1; i < 10; i++) // 초기화; 조건; 증감연산자
        {
            Debug.Log(i);
        }

        // for문에 입장했을 때
        // 1. 반복문이 시작될 때를 1로 설정해라!
        // 2. 조건 검사 A가 10보다 작은 동안만 반복문을 실행해라
        // 3. 본문 실행 : 현재의 코드값을 실행해라
        // 4. 한 번 실행이 끝날 때마다 증감연산자에 따라 1만큼 더해라 -> 2
        // 5. 출력값 : 1 2 3 4 5 6 7 8 9
        // 6. 조건을 만족하지 않으면 반복문을 종료해라

        // 구구단
        // 2x1 = 2, 2x2 = 4...... 9x9 = 81      x = 2~9    y = 1~9

        for (int X = 2; X < 10; X++)
        {
            for (int Y = 1;  Y < 10; Y++)
            {
                Debug.Log($"{X}x{Y} = {X * Y}");
            }
        }

        // 2. while문
        // 선언 형식
        int HP = 100;
        while (HP > 0) // 조건이 참일 동안
        {
            Debug.Log($"현재 HP : {HP}");
            HP--;
        }

        // 조건이 참일 경우 계속 반복
        // 1. 조건 검사
        // 2.1 조건이 참이면 본문 실행 -> 증감연산자만큼 증가 또는 감소
        // 2.2 조건이 거짓이면 반복 종료
        // 3. 출력값 : 100 99 98 ... 3 2 1
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
