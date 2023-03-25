using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;


public enum UniteState
{
    Idle,
    Walk,
}
public class Staff : MonoBehaviour
{
    private int _id;
    private int charSkinId;
    public GameObject[] charSkin;
    public string staffName;
    public int dailyWage;

    [SerializeField] private UniteState state;
    [SerializeField] private NavMeshAgent navAgent;

    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        CheckStop();
    }

    public NavMeshAgent NavMeshAgent
    {
        get { return navAgent; }
        set { navAgent = value; }
    }
    public UniteState State
    {
        get { return state; }
        set { state = value; }
    }
    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public int CharSkinID
    {
        get { return charSkinId; }
        set { charSkinId = value; }
    }

    public void InitCharID(int id)
    {
        this._id = id;
        this.charSkinId = Random.Range(0, charSkin.Length -1);
        staffName = "XXXXX";
        dailyWage = Random.Range(80, 125);
        
        
    }

    public void ChangeCharSkin()
    {
        for (int i = 0; i < charSkin.Length; i++)
        {
            if (i == charSkinId)
            {
                charSkin[i].SetActive(true);
            }
            else
            {
                charSkin[i].SetActive(false);
            }
        }
    }

    public void SetToWalk(Vector3 dest)
    {
        state = UniteState.Walk;

        navAgent.SetDestination(dest);
        navAgent.isStopped = false;
    }

    private void CheckStop()
    {
        float dist = Vector3.Distance(transform.position, navAgent.destination);

        if (dist <=3f)
        {
            state = UniteState.Idle;
            navAgent.isStopped = true;
        }
    }
    
}
