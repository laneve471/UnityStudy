using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : MonoBehaviour
{
    // public int month = 4;
    void Awake()
    {
        for (int x = 3; x <= 9; x += 2) // 3단부터 9단까지 홀수단만
        {
            Debug.Log($"==== {x}단 ===="); // 제목을 출력한 뒤

            for (int y = 1; y <= 9; y++) // 1부터 9까지 곱하기 실행
            {
                Debug.Log($"{x} x {y} = {x * y}"); // 곱셈 결과 출력
            }
        }

        /*
        int sum = 0; // 1부터 100까지의 합을 저장할 변수
        for (int i = 1; i <= 100; i++) // 1부터 100까지 반복하며
        {
            sum += i; // 해당 값을 더해 누적함
        }

        Debug.Log("1부터 100까지의 합 : " + sum); // 최종 결과 출력*/

        /*
        if (month >= 3 && month <= 5) // 만약 월이 3월 ~ 5월이라면(3, 4, 5)
        {
            Debug.Log($"month = {month}, 현재 계절 : 봄"); // 현재 계절은 봄
        }
        else if (month >= 6 && month <= 8) // 만약 6월 ~ 8월이라면(6, 7, 8)
        {
            Debug.Log($"month = {month}, 현재 계절 : 여름"); // 현재 계절은 여름
        }
        else if (month >= 9 && month <= 11) // 만약 9월 ~ 11월이라면(9 10 11)
        {
            Debug.Log($"month = {month}, 현재 계절 : 가을"); // 현재 계절은 가을
        }
        else if (month == 12 || month == 1 || month == 2) // 만약 12, 1, 2월이라면
        {
            Debug.Log($"month = {month}, 현재 계절 : 겨울"); // 현재 계절은 겨울
        }
        else // 그 이외의 값은 잘못된 값
        {
            Debug.Log($"month = {month}, 잘못된 값입니다.");
        }*/
    }
}
