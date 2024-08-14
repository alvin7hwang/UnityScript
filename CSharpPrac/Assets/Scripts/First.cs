using System.Collections;
using System.Collections.Generic;
using UnityEngine;//Unity에 있는 기능 사용

public class First : MonoBehaviour//MonoBehaviour 참조(Unity 기능 Class) 미연결시 object에 연결 불가
{
    public int count = 0; //feild에서 노출, editer 에서 수정 가능
    private float value = 1.0f;//비공개, editer에서 수정 불가
    //Unity scirpt는 life cycle에 의해 정해진 위치에 코드를 설계 후 유니티 엔진 실행으로 진행
    // Start is called before the first frame update
    //첫 프레임 시작 시 호출되는 함수
    void Start()
    {
        Debug.Log("스타트");
    }

    // Update is called once per frame
    //매 프레임 마다 호출되는 함수
    void Update()
    {
        Debug.Log(count);
        count++;
    }
}
