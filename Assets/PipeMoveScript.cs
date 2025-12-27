using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -20;
    public BirdScript birdScript;
    void Start()
    {
        birdScript = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
    }

    void Update()
    {
        if (birdScript.birdIsAlive)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
