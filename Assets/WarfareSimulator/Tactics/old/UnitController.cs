using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarfareSimulator;

namespace WarfareSimulator.old
{
    //用來控制 unit 在 unity 中的行为
    //用于接受鼠标点击并呼叫技能选择盘
    //改变颜色，当声明归零时销毁
    //永远处于某个 tile 上
    public class UnitController : MonoBehaviour
    {
        //当前控制器所控制的 unit
        public Unit unit;
        //当前 unit 所在的 tile，如存在
        public Tile tile;

        private void Start()
        {
            //在这里初始化各种玩意
        }

        //测试方法：改变以给定 range 围绕当前 tile 的颜色

        //在这里呼叫技能 UI
        //通过 unit 的 skills 加载技能
        //技能都要寻路，列出可以使用的对象（范围）

        //应该写成一个 event
        private void OnMouseDown()
        {
            DisplaySkillRange(true);
        }

        private void OnMouseUp()
        {
            DisplaySkillRange(false);
        }

        public void DisplaySkillRange(bool onMouseDown)
        {
            if (transform.parent.name.Contains("Tile"))
            {
                tile = transform.parent.GetComponent<Tile>();
                tile.tilescontroller.TestTilesColorChange(tile.transform.GetComponent<Tile>(), onMouseDown);
            }
        }
    }
}