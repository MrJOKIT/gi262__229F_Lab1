using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuctureManager : MonoBehaviour
{
    [SerializeField] private bool isConstructing;

    public GameObject curBuildingPrefeb;
    public GameObject buildingParent;

    [SerializeField] private Vector3 cursorPos;
    [SerializeField] private GameObject buildCursor;
    [SerializeField] private GameObject gridPlane;

    private void Update()
    {
        cursorPos = Selector.instance.GetCurrentTilePosition();

        if (isConstructing)
        {
            buildCursor.transform.position = cursorPos;
            gridPlane.SetActive(true);
        }
    }

    public void BeginNewBuildingPlacement(GameObject prefeb)
    {
        isConstructing = true;
        curBuildingPrefeb = prefeb;

        buildCursor = Instantiate(curBuildingPrefeb, cursorPos, Quaternion.identity);
        buildCursor.SetActive(true);
    }
}
