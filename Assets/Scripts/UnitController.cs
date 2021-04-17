using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//用來控制 unit 在 unity 中的行为
//用于接受鼠标点击并呼叫技能选择盘
//改变颜色，当声明归零时销毁
//永远处于某个 tile 上
public class UnitController : MonoBehaviour
{
    //当前控制器所控制的 unit
    public Unit unit;

    private void Start()
    {
        //在这里初始化各种玩意
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //在这里呼叫技能 UI
            //通过 unit 的 skills 加载技能
        }
    }
}
