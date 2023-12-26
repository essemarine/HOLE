using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform holeTransform;
    private Vector3 offset;
    [SerializeField] [Range(0, 3)] private float lerpValue;
    private Vector3 newPosition;
    void Start()
    {
        offset = transform.position - holeTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CameraSmoothFollow();
    }

    private void CameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, holeTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
