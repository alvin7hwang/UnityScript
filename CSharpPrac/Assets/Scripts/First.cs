using System.Collections;
using System.Collections.Generic;
using UnityEngine;//Unity�� �ִ� ��� ���

public class First : MonoBehaviour//MonoBehaviour ����(Unity ��� Class) �̿���� object�� ���� �Ұ�
{
    public int count = 0; //feild���� ����, editer ���� ���� ����
    private float value = 1.0f;//�����, editer���� ���� �Ұ�
    //Unity scirpt�� life cycle�� ���� ������ ��ġ�� �ڵ带 ���� �� ����Ƽ ���� �������� ����
    // Start is called before the first frame update
    //ù ������ ���� �� ȣ��Ǵ� �Լ�
    void Start()
    {
        Debug.Log("��ŸƮ");
    }

    // Update is called once per frame
    //�� ������ ���� ȣ��Ǵ� �Լ�
    void Update()
    {
        Debug.Log(count);
        count++;
    }
}
