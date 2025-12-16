using Unity.VisualScripting;
using UnityEngine;

public class Truck : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] GameObject[] wheels;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        for(int i = 0; i > wheels.Length; i++)
        {
            Debug.Log (wheels[i].name);
        }

        rigidbody.useGravity = false;
    }

   
    void Update()
    {
        
    }
}
