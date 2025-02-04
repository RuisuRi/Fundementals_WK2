using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public GameObject Page_1;
    public GameObject Page_2;
    public GameObject Ending_1;
    public GameObject Ending_2;
    void Start()
    {
        Page_1.SetActive(true);
        Page_2.SetActive(false);
        Ending_1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scene2()
    {
        Page_1.SetActive(false);
        Page_2.SetActive(true);
    }

    public void Ending1()
    {
        Page_1.SetActive(false);
        Ending_1.SetActive(true);
    }

}
