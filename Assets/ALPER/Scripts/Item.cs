using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour
{
    Vector2 target;
    Vector2 current;
    [SerializeField] float secondToWait = 0.1f;
    [SerializeField] float moveSpeed = 5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        current = transform.position;
        
    }


    public IEnumerator MoveTo(Vector2 targetArg)
    {
        target = targetArg;
        Debug.Log("ahhhhhh");

        while (Vector2.Distance(current,target)  > 0.001f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
            yield return null;
        }

        transform.position = target;
        

    }
     

    // Update is called once per frame
    void Update()
    {
        
    }
}
