using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//控制具体的 tile 的行为，例如改变颜色指示技能范围等等。
public class Tile : MonoBehaviour
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }

    public Tile(int positionX, int positionY)
    {
        this.PositionX = positionX;
        this.PositionY = positionY;
    }

    public void SetPosition(int positionX, int positionY)
    {
        this.PositionX = positionX;
        this.PositionY = positionY;
    }
}
