using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Plane daggingPlane;
    private Vector3 offset;
    public GameObject thisObject;

    [SerializeField] private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        // Cashe the camera
        mainCamera = Camera.main;
        thisObject = gameObject;
    }

    private void OnMouseDown()
    {
        daggingPlane = new Plane(mainCamera.transform.forward, transform.position);
        Ray camRay = mainCamera.ScreenPointToRay(Input.mousePosition);

        float planeDistance;
        daggingPlane.Raycast(camRay, out planeDistance);
        offset = transform.position - camRay.GetPoint(planeDistance);
    }

    private void OnMouseDrag()
    {
        Ray camRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        float planeDistance;
        daggingPlane.Raycast(camRay, out planeDistance);
        transform.position = camRay.GetPoint(planeDistance) + offset;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
