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

        string str8 = string.Format("{0:F2}, 3.141592"); // 소수점 둘째 자리까지
        Debug.Log(str8);

        string str9 = string.Format("{0:N}, 3141592"); // 콤마 구분 + 기본 소수점 둘째자리
        Debug.Log(str9);

        string str10 = string.Format("{0:E}, 3141592"); // 지수 표기
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

        // 문자열 탐색
        string str = "Hello, World";
        Debug.Log(str); // 출력값

        int numeric = str.IndexOf("o"); // 앞에서부터 o가 몇 번째에 있는지 -> 5
        Debug.Log(numeric); // 허나 출력값은 4 => 0에서 시작
        Debug.Log($"앞에서 검색한 첫번째 o는 {numeric}번째이다.");

        numeric = str.LastIndexOf("o");
        Debug.Log(numeric); // 8
        Debug.Log($"뒤에서 검색한 첫번째 o는 {numeric}번째이다.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str} 문장은 앞에서 Hello부터 시작한다 : {isTrue}"); // true

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str} 문장은 앞에서 Hello부터 시작한다 : {isTrue}"); // false

        isTrue = str.EndsWith("World");
        Debug.Log($"{str} 문장은 뒤에서 World부터 시작한다 : {isTrue}"); // true

        // 문자열 변형
        str = str.ToLower(); // hello, world
        str = str.ToUpper(); // HELLO, WORLD
        str = str.Insert(0, "HI~ "); // HI~ HELLO, WORLD
        str = str.Remove(0, 4); // 0부터 4개 제거 -> HELLO, WORLD

        str = "        " + str + "          "; // '            HELLO, WORLD            '
        str = str.Trim(); // 앞뒤공백 제거 => HELLO, WORLD
        // str.TrimStart(); // 앞의 공백 제거
        // str.TrimEnd(); // 뒤의 공백 제거

        str = str.Replace("HELLO", "BYE"); // BYE, WORLD

        // 문자열 분할
        string fruits = "바나나, 사과, 배, 포도";
        string[] fruitsArray = fruits.Split(',');
        Debug.Log($"과일 이름: {fruitsArray[1]}");

        //fruitsArr[0] = 바나나;
        //fruitsArr[1] = 사과;
        //fruitsArr[2] = 배;
        //fruitsArr[3] = 포도;

        //공백 기준으로 분할
        string word = "Hello world Program";
        string[] wordArr = word.Split(' ');
        //worldArr[0] = Hello

        // 문자열 다루기 string Substring
        str = "Hello, World";
        //     01234567
        string right = str.Substring(7); // World
        string left = str.Substring(0, 5); // 0부터 5개 => Hello
        string mid = str.Substring(3, 5); // lo, W

        // 활용 예제

        // 로그를 찍으면 아이템: 아이템 이름     공격력: 공격수치     등급: 등급수치
        string items = "5성전설의검-150,4성암흑지팡이-120,3성다마스커스-30";
        string[] itemsArr = left.Split(",");

        foreach (string item in itemsArr)
        {
            string[] parts = item.Split('-');
            string itemName = parts[0];
            string itemNameCut = itemName.Substring(2);

            string atk = parts[1];
            int value = int.Parse(atk); // 패싱 -> 문자를 숫자로 변경

            string grade = itemName.Substring(0, 2);

            Debug.Log($"아이템: {itemNameCut}, 공격력: {value}, 등급: {grade}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
