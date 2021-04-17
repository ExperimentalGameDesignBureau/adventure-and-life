using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//unit's template
//这里姑且认为每个 unit 是一个具体的个体，相当于 T9A 中模型的概念。
//按说 unit 因该是不继承 Monobehave，不直接挂在 go 上。但暂时先这么写，便于调试。
    //添加继承的子类，swordman bowman 等等。
public class Unit : MonoBehaviour
{
    //Unit 基于库调用相关参数，之后写 getter and setter
    //public string name;
    public string type;
    public int healthPoints;
    public int sanityPoints;
    public int meleeAttackSkill;
    public int meleeDefenceSkill;
    public int rangedAttackSkill;
    public int rangedDefenceSkill;

    public Skill[] skills;
}
