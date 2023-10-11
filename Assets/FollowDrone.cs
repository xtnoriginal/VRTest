using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDrone : MonoBehaviour
{

    [SerializeField] private  Transform droneTransform;
    private  Vector3 offset = new Vector3(0,2,-5);
    // Update is called once per frame
  void Update()

    {
        //private  Transform droneTransform;
        transform.position  =  droneTransform.position + offset;
    }
}
