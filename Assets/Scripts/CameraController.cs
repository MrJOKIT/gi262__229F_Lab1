using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float minZoomDist;
    [SerializeField] private float maxZoomDirt;
    [SerializeField] private float zoomSpeed;
    [SerializeField] private float zoomModifier;

    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Zoom();
    }

    private void Zoom()
    {
        zoomModifier = Input.GetAxis("Mouse ScrollWheel");

        float dist = Vector3.Distance(this.transform.position, _camera.transform.position);

        if (dist < minZoomDist && zoomModifier > 0f) 
        {
            return;
        }
        else if (dist > maxZoomDirt && zoomModifier < 0f)
        {
            return;
        }

        _camera.transform.position += _camera.transform.forward * zoomModifier * zoomSpeed;
    }
}
