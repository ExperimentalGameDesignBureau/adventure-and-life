using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarfareSimulator.old
{
    public class Skill
    {
        //应该包括技能图标
        //名称
        //各种效果的模版
        //子类包括各种技能的方法
        //基于「输入」「输出」的框架；不过颜色、生命值之类的需要装载 unit 然后应用方法

        public string name;
        //技能的范围
        public int range;
    }
}