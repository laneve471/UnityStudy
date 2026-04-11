using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Example06 : MonoBehaviour
{
    ///////////////////// 변수 ///////////////////////
    /*int exp1 = 50;
    int exp2 = 100;
    int exp3 = 150;
    int exp4 = 200;
    int exp5 = 250;

    // 데이터형식[] 배열 이름 = new 데이터형식[크기];
    int[] exp = new int[5] {50, 100, 150, 200, 250};*/

    int[] exp = { 50, 100, 150, 200, 250 };
    //           0    1    2    3    4

    int[] array = new int[10];
    int[] array2; // 나중에도 지정 가능

    // 2차원 배열
    int[,] array3 = { { 50, 100, 150, 200, 250, 300 }, { 5, 10, 15, 20, 25, 30 } };    

    // 3차원 배열
    int[,,] array4 = { { { 50, 100, 150, 200, 250, 300 }, { 5, 10, 15, 20, 25, 30 } }, { { 50, 100, 150, 200, 250, 300 }, { 5, 10, 15, 20, 25, 30 } } };

    void Awake()
    {
        for (int i = 0; i < exp.Length; i++) // exp.Length : 배열의 크기(원소의 개수)
        {
            Debug.Log(exp[i]); // 100
        }

        exp[5] = 250;
        exp[11] = 50; // out of range -> 한 번 크기가 정해지면 바꿀 수 없다

        array[0] = 100;
        array2 = new int[10];
        array2 = new int[exp.Length]; // exp 크기만큼 지정 가능

        Debug.Log(array3[0, 3]); // 200
        Debug.Log(array3[1, 1]); // 10
        Debug.Log(array4[1, 1, 2]); // 15
        Debug.Log(array4[0, 1, 3]); // 20


        // System Array
        int[] newArray = { 550, 600, 150, 200, 250, 300 };

        for (int i = 0; i < newArray.Length; i++)
        {
            Debug.Log("배열의 값은 : " + exp[i]); // 550, 600, 150, 200, 250, 300
        }

        Array.Sort(newArray);

        for (int i = 0; i < newArray.Length; i++)
        {
            Debug.Log($"정렬 후 배열의 값은 : {exp[i]}"); // 150, 200, 250, 300, 550, 600
        }

        int index = Array.IndexOf(newArray, 200);
        Debug.Log($"배열의 특정 값 200의 인덱스 번호는 : {index}"); // 1

        Array.Clear(newArray, 0, exp.Length); // 배열의 모든 값을 초기상태 0 or null 변경

        for (int i = 0;i < newArray.Length; i++)
        {
            Debug.Log($"초기화 후 배열의 값은 : {newArray[i]}"); // 0, 0, 0, 0, 0, 0
        }

        Array.Resize(ref newArray, 10); // 기존 6칸 배열을 10칸으로 변경, 새로 생긴 칸은 기본 값으로 채워진다
        Debug.Log($"배열의 크기 변형 후 크기는 : {newArray.Length}");

        //////////////////////// 함수 //////////////////////////
        Add(1, 2); // 1과 2의 합은 = 3
        Add(5, 10, "합"); // 5와 10의 합 = 15

        int sum = Add(3, 4); // int 버전 호출
        Debug.Log(sum); // 7

        Add(1.5f, 4.6f); // float 버전 호출
    }

    // void : 메소드가 결과값을 반환하지 않는다. (단순히 동작만 수행)
    // int : 메소드가 결과값 int를 반환해야 한다. (계산 결과값을 돌려받아 다른 곳에서 재사용)
    int Add(int A, int B, string C = "합은")   // 매개변수 : 파라미터에 직접 사용하여 쓸 수 있는 변수
    {                                           // 값이 정해진 매개변수 값은 뒤에
        int Sum = A + B;
        Debug.Log($"{A}와 {B}의 {C} = {Sum}");

        return Sum;
    }
    float Add(float A, float B)
    {
        return A + B;
    }

    //////////////// 함수 심화 ///////////////////
    /// Call by Value : 변수값을 그대로 복사해서 전달. 함수 밖의 변수는 영향 x
    void Swap(int a, int b) 
    {                 
        int temp = a;
        a = b;
        b = temp;
    }

    // Call by Reference : 변수값의 주소를 들고 그 안의 값을 직접 수정
    void Swap(ref int a, ref int b) 
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // out 키워드 : 출력 전용 매개변수. 값이 없는 변수를 초기화해서 넘겨줌
    void GetValues(out int a, out int b)
    {
        a = 10;
        b = 20;
    }

    // 가변 길이 매개변수(param)
    // 개수가 유연하게 변할 수 있는 매개변수 -> 변수의 길이가 다른 메소드가 많이 필요할 경우 사용
    // 단 매개변수의 형식은 같아야 함
    void Sum(params int[] values)
    {
        int sum = 0;  
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        Debug.Log(sum);
    }

    float Average(params float[] scores)
    {
        float sum = 0;
        for (int i = 0;i < scores.Length;i++)
            sum += scores[i];
        return sum / scores.Length;
    }

    // 명명된 매개 변수 : 코드가 길어지지만 가독성 좋음, 순서 상관 없음
    // 선택된 매개 변수 : 기본값 지정. 맨 뒤에 표시
    public void Player(string ID, int Health = 100)
    {
        Debug.Log($"ID: {ID}, HP: {Health}");
    }

    private void Start()
    {
        // out 키워드
        int x, y; // 초기화 안 해도 됨
        GetValues(out x, out y);
        Debug.Log($"x = {x}, y = {y}"); // x = 10, y = 20

        // 가변 길이 매개변수 param
        Debug.Log(Average(100, 90, 80)); // 90

        // 명명된 매개 변수
        Player(Health: 200, ID: "플레이어"); // ID: 플레이어, Health: 200

        // 선택된 매개 변수
        Player(ID: "Player"); // ID: Player, Health: 100
    }
}
