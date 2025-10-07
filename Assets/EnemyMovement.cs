using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float minimum = 2f;
    public float maximum = 3f;

    void Start()
    {
        minimum = transform.position.x;
        maximum = transform.position.x + 3;
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 5, maximum - minimum) + minimum, transform.position.y, transform.position.z);
    }
}
