using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//控制 tiles 的生成
public class TilesManager : MonoBehaviour
{
    //基于数量生成 tiles，之后改成 constructure
    public int maxX = 5;//x
    public int maxY = 5;//z
    //public const float percision = 0.0001f;
    public Tile[,] tiles;

    public GameObject tilePrefab;

    private void Start()
    {
        tiles = GenerateTiles(maxX, maxY);
    }

    private Tile[,] GenerateTiles(int length, int width)
    {
        Tile[,] tiles = new Tile[length, width];
        Vector3 vector3 = new Vector3(0, 0, 0);
        for (int i = 0; i < length; i++)
        {
            vector3.x = 0f;
            for (int j = 0; j < width; j++)
            {
                GameObject tileGameObject = GameObject.Instantiate(tilePrefab, this.transform);
                tileGameObject.name = "Tile" + i + j;
                tileGameObject.transform.position = vector3;
                tiles[i, j] = tileGameObject.GetComponent<Tile>();
                tiles[i, j].SetPosition(i, j);
                vector3.x++;
            }
            vector3.z++;
        }
        return tiles;
    }

    public List<Tile> FindTilesWithinRange(int x, int y, int range)
    {
        List<Tile> tilesWithinRange = new List<Tile>();
        foreach (Tile t in tiles)
        {
            if (Abs(t.PositionX - x) + Abs(t.PositionY - y) <= range)
            {
                tilesWithinRange.Add(t);
            }
        }
        return tilesWithinRange;
    }

    private int Abs(int i)
    {
        return i >= 0 ? i : -i;
    }
}
