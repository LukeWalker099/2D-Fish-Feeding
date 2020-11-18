using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorB : MonoBehaviour
{
    public Transform trans;
    private SpriteRenderer sr;
    public Rigidbody2D rb;


    public float horizontalSpeed;
    public float verticalSpeed;
    [SerializeField]
    private bool dirDown;
    [SerializeField]
    private bool dirLeft;

    private void Start()
    {
        // Gets the Sprite Renderer component
        sr = gameObject.GetComponent<SpriteRenderer>();

        // Gets Transform component
        trans = gameObject.GetComponent<Transform>();
    }


    private void Update()
    {
        // Checks if dirDown is true, and if it is, the Predator moves down
        if (dirDown)
        {
            transform.Translate(Vector2.down * verticalSpeed * Time.deltaTime);
        }

        // If dirDown is false, the Predator moves up
        else
        {
            transform.Translate(Vector2.up * verticalSpeed * Time.deltaTime);
        }

        // Checks if the position of the Predator is greater than or equal (to the given value) and if so, sets the direction down to true
        if (trans.position.y >= 0.5)
        {
            dirDown = true;
        }

        // If the position is not that of above, then the direction is set to false
        else if (trans.position.y <= -0.25)
        {
            dirDown = false;
        }

        if (dirLeft)
        {
            // Flips Sprite
            sr.flipX = true;

            // Moves Predator left
            transform.Translate(Vector2.left * horizontalSpeed * Time.deltaTime);
        }
        else
        {   // Moves Predator left if direction left is false
            transform.Translate(Vector2.right * horizontalSpeed * Time.deltaTime);
        }

        // Sets direction left to true
        if (trans.position.x >= 7.15)
        {
            dirLeft = true;

        }
    }
}
