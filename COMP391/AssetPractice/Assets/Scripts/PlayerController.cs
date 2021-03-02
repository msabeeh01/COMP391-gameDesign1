using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject laser;
    public GameObject laserSpawner;
    public float fireRate = 0.25f;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horiz, vert;

        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        //Debug.Log("H: " + horiz + ", V:" + vert);

        Vector2 newVelocity = new Vector2(horiz, vert);
        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;

        if (Input.GetAxis("Fire1") > 0 && timer > fireRate)
        {
            GameObject.Instantiate(laser, laserSpawner.transform.position, laserSpawner.transform.rotation);

            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
