using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public Vector2 tileSize = new Vector2Int (1, 1);
    Vector2 worldCenter = new Vector2Int(0, 0);
    public Vector2 gridSize = new Vector2Int(15, 15);


    List<Vector2> gridSystem = new List<Vector2>();


}
