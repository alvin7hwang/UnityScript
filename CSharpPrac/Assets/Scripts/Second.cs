using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Second : MonoBehaviour
{
    //text componet�� level�� exp�� ���� ������ script �۾��� ���� �־��ش�.
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
        Lv_text.text = Level.ToString();//���ڿ��� ��ȯ
        Exp_text.text = exp.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
