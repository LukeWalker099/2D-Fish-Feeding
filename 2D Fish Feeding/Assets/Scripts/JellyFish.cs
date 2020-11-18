using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFish : MonoBehaviour
{
    public Rigidbody2D rb;
    public float verticalSpeed;

    private void Start()
    {
        rb.velocity = new Vector2(0, verticalSpeed * Time.deltaTime);
    }

}
