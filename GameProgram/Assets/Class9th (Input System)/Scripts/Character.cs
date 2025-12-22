using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed;

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        transform.position = direction * speed * Time.deltaTime;

        Debug.Log(direction);
    }
}
