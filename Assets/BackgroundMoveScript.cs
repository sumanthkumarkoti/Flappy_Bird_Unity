using UnityEngine;

public class BackgroundMoveScript : MonoBehaviour
{
    public float moveSpeed = 1f;
    private float width;

    void Start()
    {
        width = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -width)
        {
            transform.position += Vector3.right * width * 2;
        }
    }
}
