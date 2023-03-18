using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Zoom System")]
    [SerializeField] private float minZoomDist;
    [SerializeField] private float maxZoomDirt;
    [SerializeField] private float zoomSpeed;
    [SerializeField] private float zoomModifier;

    [Header("Camera Move")] 
    [SerializeField] private float moveSpeed = 150f;

    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Zoom();
        MoveByKB();
    }

    private void Zoom()
    {
        zoomModifier = Input.GetAxis("Mouse ScrollWheel");

        float dist = Vector3.Distance(this.transform.position, _camera.transform.position);

        if (Input.GetKey(KeyCode.Z))
        {
            zoomModifier = 0.01f;
        }
        else if (Input.GetKey(KeyCode.X))
        {
            zoomModifier = -0.01f;
        }

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

    private void MoveByKB()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 dirMove = transform.forward * zInput + transform.right * xInput;

        transform.position += dirMove * moveSpeed * Time.deltaTime;
    }
}
