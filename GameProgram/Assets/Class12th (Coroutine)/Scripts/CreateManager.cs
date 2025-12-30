using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 5f)
        {
            GameObject clone;

            clone = Instantiate(prefab);

            clone.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

            timer = 0f;
        }
    }
}
