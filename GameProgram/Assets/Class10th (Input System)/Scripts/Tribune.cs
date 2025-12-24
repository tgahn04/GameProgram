using UnityEngine;

public class Tribune : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }
}

// OnCollisionEnter() 충돌 했을때
// OnCollisionStay() 충돌 중일 때
// OnCollisionExit() 충돌이 끝났을 때