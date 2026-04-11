using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 6. 명시적 형변환 예시
        int intNum02 = 50000;
        short shortNum = (short)intNum02;


        // 5. 암시적 형변환 예시
        int intNum01 = 10;
        double doubleNum = intNum01; // 암시적 타입 변환
        Debug.Log("intNum01의 값 : " + intNum01);
        Debug.Log("intNum01의 값 : " + intNum01.GetType());
        Debug.Log("doubleNum의 값 : " + doubleNum);
        Debug.Log("doubleNum의 값 : " + doubleNum.GetType());

        int number = 31;
        object objValue = number; // boxing
        int valueInt = (int)objValue; // unboxing

        // 문자열
        string stringValue = "실감미디어컴퓨팅기초 교과목";
        char charValue = '가'; // 아스키코드
        int code = charValue;


        float floatValue = 3.141592f;
        double doubleValue = 3.141592653589793;

        
        sbyte sbyteValue = -128;
        byte byteValue = 255;

        short shortValue = -32768;
        ushort ushortValue = 65535;

        int intValue = -2147483648;
        uint uintValue = 4294967295;



        int Value = 100;
        Debug.Log("Value:" + Value);
        Debug.Log(int.MaxValue); // int의 최댓값
        Debug.Log(int.MinValue); // int의 최솟값

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
