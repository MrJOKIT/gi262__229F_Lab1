using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefeb;
    public GameObject staffParent;

    public static GameManager instance;

    private void Start()
    {
        GenerateCamdidate();
    }

    private void GenerateCamdidate()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject staffObj = Instantiate(staffPrefeb, staffParent.transform);
            Staff farmer = staffObj.GetComponent<Staff>();
            
            
            farmer.InitCharID(i);
        }
    }
}
