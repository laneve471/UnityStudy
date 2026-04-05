using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        // 
        string str1 = "Hello World";
        Debug.Log(str1);

        string str2 = string.Format("{0} {1} {2}", "Hello", "World", "Unity"); // 0 = Hello 1 = World
        Debug.Log(str2);

        string str3 = string.Format("플레이어 {0}의 점수는 {1}점", "한정원", 100);
        Debug.Log(str3); // 플레이어 한정원의 점수는 100점

        string str4 = string.Format("{0, -5}{1, 5}", "ID", "Score");
        Debug.Log(str4); // ID는 5만큼 왼쪽정렬, Score는 5만큼 오른쪽 정렬

        string str5 = string.Format("{0}{1}", "ID", "Score");
        Debug.Log(str5); // IDScore

        string str6 = string.Format("{0:D5}, 123"); // 10진수, 최소 5자리 출력, 빈칸은 0으로 채움
        Debug.Log(str6);

        string str7 = string.Format("{0:X}, 255"); // 16진수
        Debug.Log(str7);

        string str8 = string.Format("{0:F2}, 3.141592"); // 소수점 2자리까지
        Debug.Log(str8);

        // 더 있음
        string str9 = string.Format("{0:D5}, 123");
        Debug.Log(str9);

        string str10 = string.Format("{0:D5}, 123");
        Debug.Log(str10);

        // 서식 문자열(날짜)
        DateTime now = DateTime.Now;

        string strTime1 = string.Format("{0:yyyy-MM-dd}", now);
        string strTime2 = string.Format("{0:HH-mm-ss}", now);
        string strTime3 = string.Format("{0:yyyy-MM-dd dddd tt hh:mm}", now);

        Debug.Log(strTime1);
        Debug.Log(strTime2);
        Debug.Log(strTime3);

        // 문자열 보간
        int minutes = 1;
        int seconds = 30;

        Debug.Log(string.Format("{0}{1}{2}", minutes, ":", seconds)); // string.Format()
        Debug.Log($"{minutes}:{seconds}"); // 문자열 보간
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
