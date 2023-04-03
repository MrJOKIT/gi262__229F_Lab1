using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefeb;
    public GameObject staffParent;
    public GameObject spawmPos;
    public GameObject rallryPos;
    
    //resource
    public int money;
    public int staff;
    public int wheat;
    public int melon;
    public int corn;
    public int apple;
    
    public static GameManager instance;

    private void Start()
    {
        instance = this;
        GenerateCamdidate();
        money = 25000;
        UI.instance.UpdateHeaderPanel();
    }

    private void GenerateCamdidate()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject staffObj = Instantiate(staffPrefeb, staffParent.transform);
            Staff farmer = staffObj.GetComponent<Staff>();
            
            
            farmer.InitCharID(i);
            farmer.ChangeCharSkin();
            
            farmer.SetToWalk(rallryPos.transform.position);
        }
    }
}
