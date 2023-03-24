using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour            
{
    public int herbNum = 1;                     //정수 herbNum 선언후에 1을 입력(public 추가 ,

    void Start()
    {


        if (herbNum == 1)                    //조건식 herbNum 이 1일 경우 안에 로직을 실행한다.
        {
            Debug.Log("체력을 50 회복");     //console.log 창에 조건이 만족될 경우 해당 내용을 표시
        }
        else
        {
            Debug.Log("체력 -50");            //console.log 창에 조건이 만족될 경우 해당내용을 표시
        }



    }
}
    

