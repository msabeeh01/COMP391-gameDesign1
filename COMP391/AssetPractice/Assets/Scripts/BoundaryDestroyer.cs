using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerExit2D(Collider2D other) // when something leaves the box, do this: (other = other collider interacting with this one)
    {
        Destroy(other.gameObject);//delete the entire other gameObject
    }
}
