using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour            
{
    public int herbNum = 1;                     //���� herbNum �����Ŀ� 1�� �Է�(public �߰� ,

    void Start()
    {


        if (herbNum == 1)                    //���ǽ� herbNum �� 1�� ��� �ȿ� ������ �����Ѵ�.
        {
            Debug.Log("ü���� 50 ȸ��");     //console.log â�� ������ ������ ��� �ش� ������ ǥ��
        }
        else
        {
            Debug.Log("ü�� -50");            //console.log â�� ������ ������ ��� �ش系���� ǥ��
        }



    }
}
    

