using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Second : MonoBehaviour
{
    //text componet에 level과 exp에 대한 내용을 script 작업을 통해 넣어준다.
    [SerializeField]
    private Text Id_text;
    [SerializeField]
    private Text Lv_text;
    [SerializeField]
    private Text Exp_text;

    public string Id;
    [Range(1, 99)] public int Level;
    [Range(0.0f, 100.0f)] public float exp;
    // Start is called before the first frame update
    void Start()
    {
        Id_text.text = Id;
        Lv_text.text = Level.ToString();//문자열로 변환
        Exp_text.text = exp.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
