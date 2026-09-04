using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 2f;
    public float moveRange = 3f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, moveRange * 2) - moveRange;

        transform.position = new Vector3(
            startPos.x + x,
            startPos.y,
            startPos.z
        );
    }
}