using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFish : MonoBehaviour
{
    [SerializeField]
    private bool dirDown;
    private float verticalSpeed = 1;
    public Transform trans;

    private void Update()
    {
        // Checks if dirDown is true, and if it is, the Predator moves down
        if (dirDown)
        {
            transform.Translate(Vector2.up * verticalSpeed * Time.deltaTime);
        }

        // If dirDown is false, the Predator moves up
        else
        {
            transform.Translate(Vector2.down * verticalSpeed * Time.deltaTime);
        }

        // Checks if the position of the Prey is greater than or equal (to the given value) and if so, sets the direction down to true
        if (trans.position.y >= 3.3)
        {
            dirDown = false;
        }

        // If the position is not that of above, then the direction is set to false
        else if (trans.position.y <= 0.70)
        {
            dirDown = true;
        }

    }

}
