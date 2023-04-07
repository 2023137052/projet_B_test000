using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player
{
    private int hp = 100;                                       //���� Hp�� private�ϰ� ���� 100�ӷ�
    private int Power = 50;                                     //���� Power�� private�ϰ� ���� 50�Է�

    public void Attack()
    {
        Debug.Log(this.Power + "�������� ������.");
    }

    public  void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ӿ���.");
    }

    public int GetHp()
    {
        return hp;
    }
}


public class Test_008 : MonoBehaviour
{

    public Text playerHp;                                               //Player Hp �����ִ� UI
    public Text player2Hp;                                              //Player2 HP �����ִ� UI
   
    Player mPlayer = new Player();                                      //Player Ŭ���� ���� New <==
    Player mPlayer2 = new Player();                                     //Player2 Ŭ���� ���� New <==
    // Start is called before the first frame update
    void Start()
    {

        // mPlayer.Attack();                                                 //Player �޼ҵ� Attack ȣ��
        // mPlayer.Damage(30);                                               //Player �޼ҵ� Damage ȣ��
        // Debug.Log(mPlayer.GetHp());                                       //Player�� Hp�� �����ش�
    }

    // Update is called once per frame
    void Update()
    {
        playerHp.text = "Player1 HP : " +mPlayer.GetHp().ToString();                        //Player�� Hp�� UI�� ǥ��
        playerHp.text ="Player2 HP : "+ mPlayer2.GetHp().ToString();                        //Player�� Hp�� UI�� ǥ��

        if (Input.GetMouseButtonDown(0))                                //���� ���콺
        {
            mPlayer.Damage(1);                                          //Player �޼ҵ� Damage ȣ��
        }
        if (Input.GetMouseButtonDown(0))                                //������ ���콺
        {
            mPlayer2.Damage(1);                                         //Player2 �޼ҵ� Damage ȣ��
        }
    }
}