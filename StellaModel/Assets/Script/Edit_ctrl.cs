using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edit_ctrl : Scene_Manager
{
    public void editscene(string a)
    {
        Zodiac_Info.curr = a;
        gotoScene();
    }
}
