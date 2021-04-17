using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//控制 tiles 的生成
public class TilesManager : MonoBehaviour
{
    //基于数量生成 tiles，之后改成 constructure
    public int maxX;//Length
    public int maxZ;//Width
    //public const float percision = 0.0001f;

    public GameObject tilePrefab;

    private void Start()
    {
        GenerateTiles(maxX, maxZ);
    }

    private void GenerateTiles(int x, int z)
    {
        Vector3 vector3 = new Vector3(0, 0, 0);
        for (int i = 0; i < x; i++)
        {
            vector3.x = 0f;
            for (int j = 0; j < z; j++)
            {
                GameObject.Instantiate(tilePrefab, this.transform).transform.position = vector3;
                vector3.x++;
            }
            vector3.z++;
        }
    }
}
