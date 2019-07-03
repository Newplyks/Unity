using Assets.Resources;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueControl : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshPro dialogueText;
    public string namePlace;

    int count = 0;
    string[] text= new string[2]{
        "Здравствуйте!  Меня зовут Читалка, я - символ научной библиотеки ОмГТУ…➭",
        "Я расскажу Вам о библиотечных фондах и покажу их расположение…➭" }
    ;
    
    

    void Start()
    {
        dialogueText.SetText(text[count]);
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        switch (count)
        {
            
            case 0:
                dialogueText.SetText(text[0]);
                count++;
                break;
            case 1:
                dialogueText.SetText(text[1]);
                count++;
                break;
            case 2:
                dialogueText.SetText(Data.textPlace[namePlace]);
                count++;
                break;
            case 3:
                gameObject.SetActive(false);
                count = 1;
                break;
        }
    }
}
