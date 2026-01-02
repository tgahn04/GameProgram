using UnityEngine;
using UnityEngine.Audio;

public class Unit : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioSource audioSource;

    public void Emit()
    {
        audioSource.clip = Resources.Load<AudioClip>("Attack");

        audioSource.Play();
    }
}
