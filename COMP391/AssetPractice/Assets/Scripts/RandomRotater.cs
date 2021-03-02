using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotater : MonoBehaviour
{
    public float maxRotateValue = 200;//create a max changeable rotation value
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.value * maxRotateValue;//this randomly rotates the object it is assigned to withiin the range given
    }

}
