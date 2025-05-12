using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SumaYResultadoUI : MonoBehaviour
{
    public TMP_InputField InputNum1;
    public TMP_InputField InputNum2;
    public TextMeshProUGUI TXTresultado;
    int num1;
    int num2;


    void Start()
    {
        TXTresultado.text = "";
    }


    public void SumarYMostrar()
    {
        num1 = int.Parse(InputNum1.text);
        num2 = int.Parse(InputNum2.text);

        TXTresultado.text = (num1 + num2).ToString();
        Debug.Log("Suma Realizada");
    }

}
