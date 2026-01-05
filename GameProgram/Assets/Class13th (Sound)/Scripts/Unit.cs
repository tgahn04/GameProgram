using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;

public enum AnimationState
{
    IDLE,
    MOVE,
    ATTACK,
    DIE
}

public class Unit : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AudioSource audioSource;
    [SerializeField] int index = 0;
    [SerializeField] AnimationState state;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (animator.IsInTransition(0))
        {
            Debug.Log("Transtion");
        }
    }

    public void Transtion(int count)
    {
        if(count == 0)
        {
            state = (AnimationState)((int)state % 3);

            return;
        }

        index += count;

        if (index % 3 == 0)
        {
            state++;
        }
    }    

    

    public void Emit()
    {
        Debug.Log(state.ToString());

        audioSource.clip = Resources.Load<AudioClip>(state.ToString());

        audioSource.Play();
    }
}
