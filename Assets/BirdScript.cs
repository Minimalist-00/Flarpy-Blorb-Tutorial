using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb; 
    public float flapStrength;

    void Start()
    {
        gameObject.name = "Bob Birdington";
    }

    void Update()
    {
         if(Keyboard.current.spaceKey.wasPressedThisFrame)
         {
             rb.linearVelocity = Vector2.up * flapStrength;
         }
    }
}
