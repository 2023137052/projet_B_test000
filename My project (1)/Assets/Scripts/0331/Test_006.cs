using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    // Start is called before the first frame update

    public int[] array = new int[5];                            //�迭 5�� ������ �����ϰ� �̸��� array��� �Ѵ�
    public int[] point = { 83, 99, 52, 93, 15 };
    void Start()
    {
        array[0] = 2;                                           //���� �迭�� ������ ���� �Է�
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)                               //for���� ���ؼ� console â�� ��� Array �迭 �ȿ� �ִ� 0 - 4����
        {                                                       //������ ǥ��
            Debug.Log(array[i]);
        }

        Debug.Log("====================================");

        for (int i = 0; i < point.Length; i++)                   //�迭�� ���̸� �������� ���� (�迭�̸�.Length) => ���ڷ� ���� ->5
        {
            if (point[i] > 90)                                   //point[i] ���� for�� ���鼭 ���ؼ� 90�� �Ѵ� ���ڸ� ����Ʈ �Ѵ�
            {
                Debug.Log(point[i]);
            }
        }

        int sum = 0;                                            //�� ���� ���ϱ� ���ؼ� �ӽ������� sum ���� ����

        for (int i = 0; i < point.Length; i++)
        {
            sum += point[i];
        }

        int average = sum / point.Length;

        Debug.Log(average);
    }

}
