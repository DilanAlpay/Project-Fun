using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayVariable : MonoBehaviour
{
    public Variable variable;
    private TMP_Text _display;
    public string prefix, postfix;
    [Range(0,4)]
    public int digits;
    //private string format = "";

    private void Awake()
    {
        _display = GetComponent<TMP_Text>();

        /*
        for (int i = 0; i < digits; i++)
        {
            format += "0";
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        Display();
    }

    private void Display()
    {
        if (!variable) return;
        _display.text = variable.ToString();
    }
}
