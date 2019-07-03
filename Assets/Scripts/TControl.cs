using Assets.Resources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TControl : MonoBehaviour
{
    public GameObject girl;
    public GameObject TextView;
    public GameObject dialog;
    private Text text;
    bool isWalk = false;
    float moveSpeed = 5.5f;
    float step;
    private Animator animator;

    void Start()
    {
        step = moveSpeed * Time.deltaTime;
        animator = girl.GetComponent<Animator>();
        Data.defaultPosition = girl.transform.localPosition;
    }

    void Update()
    {
        if (isWalk)
        {
            girl.transform.position = Vector3.MoveTowards(girl.transform.position, transform.position, step);
        }
    }

    public void OnMouseDown()
    {
        isWalk = true;
        animator.SetTrigger("Walk");
        girl.transform.LookAt(transform, Vector3.up);
        girl.transform.Find("Dialogue").gameObject.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        isWalk = false;
        animator.SetTrigger("Idle");
        TextView.SetActive(true);
        GameObject pointA = GameObject.Find("Point A");
        GameObject pointB = GameObject.Find("Point B");
        switch (girl.GetComponent<GirlControl>().namePlace)
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
        text = GameObject.Find("TextInf").GetComponent<Text>();
        TextAsset textFile;


        switch (gameObject.name)
        {
            case "OOUL star":
                textFile  = Resources.Load<TextAsset>("OOUL");
                text.text = textFile.text;
                pointB.transform.localPosition = new Vector3(-82, 33);
                break;
            case "OKPR star":
                pointB.transform.localPosition = new Vector3(268, 158);
                textFile = Resources.Load<TextAsset>("OKPR");
                text.text = textFile.text;
                break;
            case "Mediacentr star":
                pointB.transform.localPosition = new Vector3(68, 142);
                textFile = Resources.Load<TextAsset>("Mediacentr");
                text.text = textFile.text;
                break;
        }

        if (pointB.transform.localPosition == pointA.transform.localPosition)
        {
            pointB.transform.localPosition = new Vector3(1000, -1000);
        }

    }

}
