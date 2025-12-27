using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject Pipe;
    public float spawnRate = 2f;
    public float heightOffset = 10f;
    private float timer = 0f;
    public BirdScript birdScript;

    void Start()
    {
        SpawnPipe();
        birdScript = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
    }

    void Update()
    {
        if (birdScript.birdIsAlive)
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                SpawnPipe();
                timer = 0f;
            }
        }

    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
