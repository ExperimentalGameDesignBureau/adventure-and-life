﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//控制具体的 tile 的行为，例如改变颜色指示技能范围等等。
public class Tile : MonoBehaviour
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public TilesManager tilesManager { get; private set; }

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

    private void Start()
    {
        tilesManager = this.transform.parent.GetComponent<TilesManager>();
    }


    //测试方法：改变以给定 range 围绕当前 tile 的颜色
    private void OnMouseDown()
    {
        tilesManager.TestTilesColorChange(transform.GetComponent<Tile>(), true);
    }

    private void OnMouseUp()
    {
        tilesManager.TestTilesColorChange(transform.GetComponent<Tile>(), false);
    }

    public void ChangeColor(string color)
    {
        switch (color)
        {
            case "red":
                transform.GetComponent<Renderer>().material.color = Color.red;
                break;
            default:
                transform.GetComponent<Renderer>().material.color = Color.white;
                break;
        }
    }
}
