using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour
{
    Camera _camera;

    private void Start()
    {
        _camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    private void Update()
    {
        transform.rotation = _camera.transform.rotation;
    }
}
