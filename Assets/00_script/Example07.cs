using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example01
{
    public class Player
    {
        // 멤버변수
        public string name;
        public int hp;
        public int atk;

        // 생성자
        public Player(string PlayerName, int PlayerHp, int PlayerATK)
        {
            name = PlayerName;
            hp = PlayerHp;
            atk = PlayerATK;
        }

        // 멤버함수
        public void Attack(Player target)
        {
            Debug.Log($"{name}이/가 {atk} 데미지를 주었습니다.");

            target.hp -= atk;

            if (target.hp > 0)
            {
                Debug.Log($"{target.name}이/가 {atk} 데미지를 받았습니다.");
                Debug.Log($"{target.name}의 체력이 {target.hp} 남았습니다.")
            }
            else
            {
                Debug.Log($"{target.name}이/가 사망했습니다.");
            }
        }
    }
}

public class Entity
{
    public string ID = "인간"; // public : 클래스 외부에서도 접근이 가능한 접근지정자
    protected int HP; // private : 클래스 외부에서 접근 불가능, 내부에서도 접근 불가능
                      // protected : 클래스 외부에서 접근 불가능, 내부에서는 접근 가능

    // 캡슐화 Getter Setter
    public void SetHP(int hp)
    {
        HP = hp;
    }

    public int GetHP() 
    { 
        return HP; 
    }
    public virtual void Attack() // virtual : 부모 클래스에서 "이 메소드는 재정의 가능하다" 라고 선언하는 키워드
    {
        Debug.Log("적을 공격한다.");
    }
}

public class Player : Entity
{
    public new string ID;
    // 생성자
    public Player()
    {
        ID = "전사";
        HP = 100;
    }

    public void PopUp()
    {
        //Debug.Log($"종족:{ID} 직업:{ID}"); // 기본적으로 this.ID
        Debug.Log($"종족:{base.ID} 직업:{this.ID}");
    }
}

public class Slime : Entity
{
    public override void Attack() // override : 자식 클래스에서 "부모 메소드를 재정의한다"라고 선언하는 키워드
    {
        Debug.Log("슬라임의 몸통박치기 공격!");
    }
}

public class Dragon : Entity
{
    public override void Attack()
    {
        Debug.Log("드래곤의 화염 공격!");
    }
}


public class Example07 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Example01.Player player01 = new Example01.Player("플레이어", 500, 100);
        Example01.Player player02 = new Example01.Player("플레여", 50, 10);

        //Debug.Log(player01.name);
        //Debug.Log(player01.hp);
        //Debug.Log(player02.name);
        //Debug.Log(player02.hp);

        player01.Attack(player02);

        /*Entity p1 = new Entity();
        p1.ID = "플레이어";
        //p1.HP = 200; // 오류
        p1.SetHP(200);
        Debug.Log(p1.GetHP()); */

        Player p1 = new Player();
        p1.PopUp();

        Entity slime = new Slime(); // 업캐스팅
        slime.Attack(); // 슬라임의 몸통박치기 공격!

        Entity dragon = new Dragon();
        dragon.Attack(); // 드래곤의 화염 공격!
    }
}
