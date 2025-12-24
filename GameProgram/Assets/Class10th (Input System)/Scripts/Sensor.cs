using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        if (other.tag == "Ball")
        {
            other.GetComponent<Control>().Soar();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Control>().Initialize();
    }

    private void FixedUpdate()
    {
        
    }
}
// OnTriggerEnter 충돌 했을때
// OnTriggerStay 충돌 중일 때
// OnTriggerExit 충돌이 끝났을 때
