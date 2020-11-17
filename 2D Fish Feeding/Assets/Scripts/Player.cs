using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    private SpriteRenderer sr;
    private Player player;
    private Animator anim;

    [Header("Health")]
    [SerializeField]
    private int currentHealth;
    [SerializeField]
    private int maxHealth;

    public float movSpeed;

    private Vector2 originalPos = new Vector2(0, 0);


    private void Start()
    {
        // Health Setup

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        // Gets the Animation Component
        anim = GetComponent<Animator>();

        // Gets the Player Component
        player = GetComponent<Player>();

        // Gets the Sprite Renderer component 
        sr = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * movSpeed * Time.deltaTime); // Move left
            sr.flipX = true; // Flips player sprite
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * movSpeed * Time.deltaTime); // Move right
            sr.flipX = false; // Flips player sprite
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * movSpeed * Time.deltaTime); // Move up
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) 
        {
            transform.Translate(Vector2.down * movSpeed * Time.deltaTime); // Move down
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fish"))
        {
            Debug.Log("Hit!");
            player.enabled = false;
            sr.color = new Color(1f, 0f, 0f, 1); // Sets Player colour to Red on Hit
            currentHealth -= 1; // Subtract 1 health on hit
            StartCoroutine("spawnDelay"); // Delay player respawn 

            if (currentHealth < 1)
            {
                // Change to dead fish
                anim.SetBool("isDead", true);
                StartCoroutine("colourDelay");
                // open menu

            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
            player.enabled = true;
            sr.color = new Color(1f, 1f, 1f, 1); // Changes Player colour back to normal
    }

    IEnumerator spawnDelay()
    {
        yield return new WaitForSeconds(0.3f);
        transform.position = originalPos;
    }

    IEnumerator colourDelay()
    {
        yield return new WaitForSeconds(0.4f);
        sr.color = new Color(1f, 0f, 0f, 1); // Sets Player colour to Red on Hit
        player.enabled = false;
    }

}
