using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Video 
//https://www.youtube.com/watch?v=eL_zHQEju8s

public class Floater : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 3f;

    private void FixedUpdate()
    {
        if(transform.position.y < 0f)
        {
            float displacementMultiplier = Mathf.Clamp01(-transform.position.y / depthBeforeSubmerged) * displacementAmount;
        }
    }
}
