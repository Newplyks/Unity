using Assets.Resources;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class GirlControl : MonoBehaviour
{

    public GameObject dialogue;
    public TextMeshPro dialogueText;
    public string namePlace;

    int count = 0;
    string[] text = new string[2]{
        "Здравствуйте!  Меня зовут Читалка, я - символ библиотеки ОмГТУ…",
        "Я расскажу вам о библиотечных фондах и покажу их расположение…" }
    ;


    void Start()
    {
        dialogueText.SetText(text[count]);
        gameObject.GetComponent<Animator>().SetTrigger("Hi");
        count++;
        

    }

    void OnMouseDown()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Hi");
    }

    public void SetPointA()
    {
        GameObject pointA = GameObject.Find("Point A");
        switch (namePlace)
        {
            case "Mediacentr":
                pointA.transform.localPosition = new Vector3(68, 142);
                break;
            case "OKPR":
                pointA.transform.localPosition = new Vector3(268, 158);
                break;
            case "OOUL":
                pointA.transform.localPosition = new Vector3(-82, 33);
                break;
        }
    }
}
