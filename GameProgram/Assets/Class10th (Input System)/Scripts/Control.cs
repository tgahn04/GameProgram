using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] float power;
    [SerializeField] ForceMode forceMode;
    [SerializeField] Vector3 direction;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();

        forceMode = ForceMode.Force;
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * power, forceMode);
    }
    
    public void Soar()
    {
        power = 0.25f;

        forceMode = ForceMode.Impulse;

        direction = Vector3.up;
    }

    public void Initialize()
    {
        forceMode = ForceMode.Force;

        power = 5f;
    }
}
