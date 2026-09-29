using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsalive = true;

    public AudioSource audioSource;
    public AudioClip flapSound;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && birdIsalive == true)
        {
            rb.linearVelocity = Vector2.up * flapStrength;

            audioSource.PlayOneShot(flapSound);
        }

        if (transform.position.x > 10 || transform.position.y < -10)
        {
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsalive = false;
    }
}