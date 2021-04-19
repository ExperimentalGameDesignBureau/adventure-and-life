using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarfareSimulator.old
{
    //控制具体的 tile 的行为，例如改变颜色指示技能范围等等。
    public class Tile : MonoBehaviour
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public TilesController tilescontroller { get; private set; }

        public Tile(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

        public void SetPosition(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

        private void Start()
        {
            //tilescontroller = this.transform.parent.GetComponent<TilesController>();
            tilescontroller = GameObject.FindGameObjectWithTag("GameController").GetComponent<TilesController>();
        }


        //private void OnMouseDown()
        //{
        //    tilescontroller.TestTilesColorChange(transform.GetComponent<Tile>(), true);
        //}

        //private void OnMouseUp()
        //{
        //    tilescontroller.TestTilesColorChange(transform.GetComponent<Tile>(), false);
        //}

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
}