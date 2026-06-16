using Unity.VisualScripting;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{

    private Collider2D currentSushi;


    private void Update()
    {
        if (currentSushi != null && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Selam! Sushi Selected!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sushi"))
        {
            currentSushi = collision;
            Debug.Log("Sushi entered the zone!");
        }
    }


    
}
