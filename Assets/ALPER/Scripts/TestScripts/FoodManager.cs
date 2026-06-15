using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public Vector2Int[] movePoints;
    public Vector2 destinationVector;
    public Vector2 returnVector;
    float waitingTime = 0.25f;
    [SerializeField] GridManager gridManager;
    [SerializeField] bool isLooping;

    public List<Item> items = new List<Item>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(MoveItems());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveItems()
    {
        //destinationVector = movePoints[0].position


        if (!isLooping)
        {
            yield break;
        }
        while (isLooping)
        {
            for (int i = 0; i < movePoints.Length; i++)
            {
                foreach (var item in items)
                {
                    destinationVector = CellToWorldConversion(movePoints[i]);

                    StartCoroutine(item.MoveTo(destinationVector));
                    //Debug.Log(item.ToString());

                    yield return new WaitForSeconds(waitingTime);

                }


                yield return new WaitForSeconds(1f);

                //Debug.Log("hello mom");

            }
        }
        yield return null;


    }

    public Vector2 CellToWorldConversion(Vector2Int cellPosition)
    {
        return new Vector2(
            (cellPosition.x * gridManager.tileSize.x) + (gridManager.tileSize.x / 2f),
            (cellPosition.y * gridManager.tileSize.y) + (gridManager.tileSize.y / 2f)
        );// multiply by tile size then add to tile size/2 to get corner of Tile
    }
}
