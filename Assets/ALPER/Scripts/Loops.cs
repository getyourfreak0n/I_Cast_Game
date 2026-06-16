using UnityEngine;

public class Loops : MonoBehaviour
{
    [SerializeField] private Transform targetPos;



    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position , targetPos.position , 5f * Time.deltaTime); 
        Debug.Log(Vector3.Distance(transform.position, targetPos.position));
    }
}
