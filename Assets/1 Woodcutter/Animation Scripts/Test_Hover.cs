using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test_Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator guyAnim;

    private void Start()
    {
        guyAnim = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //string name
        //bool value = T/F
        guyAnim.SetBool("IsIdle",true);
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        guyAnim.SetBool("IsIdle", false);
    }
}
