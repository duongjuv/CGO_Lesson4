using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] public Transform target;
    public Vector3 offset;
    private float smoothedSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
       //offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.position = target.transform.position - offset;
        transform.LookAt(target.transform.position);*/
        
    }
    
    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothedSpeed * Time.deltaTime);
        // Quaternion quaternion = Quaternion.LookRotation(target.position);
        // transform.rotation = quaternion;
        transform.position = smoothedPosition;
        transform.LookAt(target.position);
    }
}
