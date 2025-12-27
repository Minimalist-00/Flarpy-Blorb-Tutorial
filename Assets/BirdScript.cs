using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength;
    public LogicScript logicScript;
    public bool birdIsAlive = true;
    float topBound;
    float bottomBound;

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        topBound = Camera.main.orthographicSize;
        bottomBound = -Camera.main.orthographicSize;
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdIsAlive)
        {
            rb.linearVelocity = Vector2.up * flapStrength;
        }
        if (transform.position.y > topBound || transform.position.y < bottomBound)
        {
            logicScript.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        birdIsAlive = false;
    }
}
