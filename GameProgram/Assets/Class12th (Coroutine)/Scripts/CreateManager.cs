using UnityEngine;
using System.Collections;
using UnityEngine.VFX;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform[] transforms;
    [SerializeField] int random;
    [SerializeField] GameObject clone;
    WaitForSeconds wait;

    // [SerializeField] float timer = 0f;

    // void Update()
    // {
    //     timer += Time.deltaTime;
    // 
    //     if (timer > 5f)
    //     {
    //         clone = Instantiate(prefab);
    // 
    //         clone.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    // 
    //         timer = 0f;
    //     }
    // }

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    void Awake()
    {
        wait = new WaitForSeconds(5f);
    }

    IEnumerator Coroutine()
    {

        while (true)
        {
            random = Random.Range(0, transforms.Length);

            yield return wait;

            clone = Instantiate(prefab, gameObject.transform);

            clone.transform.localPosition = transforms[random].position;

            clone.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }
    
}

// public interface IEnumator
// {
//     object Current { get; } 현재 위치의 데이터
//  
//     bool MoveNext() 다음위치로 이동, 데이터가 있으면 true 없으면 false
//     
//     void Reset() index 위치를 초기화        
// }
