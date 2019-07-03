using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Resources;

public class UIControl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject viewText;
    public GameObject viewMap;
    public GameObject mapButton;
    public GameObject pointInfo;
    public GameObject viewAbout;
    private GameObject[] girls;
    bool isOpenedInfo = false;
    Text text;

    void Start()
    {
        girls = GameObject.FindGameObjectsWithTag("Girl");
        text = GameObject.Find("TextPoint").GetComponent<Text>();
        pointInfo.SetActive(false);
        viewText.SetActive(false);
        viewAbout.SetActive(false);
        viewMap.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseTextView()
    {
        foreach (GameObject gameObject in girls)
        {
            gameObject.transform.localPosition = Data.defaultPosition;
            gameObject.transform.localRotation = new Quaternion(0, 180, 0,1);
        }
        viewText.GetComponent<Animator>().SetTrigger("Close");
        GameObject.Find("ImageMap").SetActive(true);
        viewText.SetActive(false);
    }

    public void OpenMapView()
    {
        viewMap.SetActive(true);
        mapButton.SetActive(false);
    }

    public void CloseMapView()
    {
        viewMap.GetComponent<Animator>().SetTrigger("Close");
        viewMap.SetActive(false);
        mapButton.SetActive(true);
    }

    public void OpenInfoPoint(int number)
    {
        if (!pointInfo.activeSelf)
        {
            pointInfo.SetActive(true);
            
        }
        text.text = Data.points[number].ToString();
        text.GraphicUpdateComplete();
        isOpenedInfo = true;
        //pointInfo.GetComponent<Animator>().SetTrigger("Down");
    }

    public void CloseInfoPoint()
    {
        pointInfo.SetActive(false);
        text.text = "";

    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OpenAbout()
    {
        viewAbout.SetActive(true);
    }

    public void CloseAbout()
    {
        viewAbout.SetActive(false);
    }
}
