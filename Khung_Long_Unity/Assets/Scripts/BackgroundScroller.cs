using UnityEngine;

public class BackgroundLooper : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 2f;
    [SerializeField] private float backgroundWidth = 20f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        if (transform.position.x <= startPos.x - backgroundWidth)
        {
            transform.position += Vector3.right * backgroundWidth * 2f;
        }
    }
}