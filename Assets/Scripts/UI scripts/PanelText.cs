using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelText : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animations;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        animations = gameObject.GetComponent<Animator>();
        animations.SetTrigger("Open");
    }




}
