using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointControl : MonoBehaviour
{
    // Start is called before the first frame update
    public int numberPoint;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        switch (numberPoint)
        {
            case 8:
                OpenInfoPoint(numberPoint);
                break;
        }
    }

    private void OpenInfoPoint(int number)
    {
        Debug.Log("Open point" + numberPoint);
    }

    public void CloseInfoPoint()
    {
        Debug.Log("Close point" + numberPoint);
    }
}
