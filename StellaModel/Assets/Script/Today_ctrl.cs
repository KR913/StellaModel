using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Today_ctrl : MonoBehaviour
{
    int zodiac = 0;
    GameObject target;
    Animator anim;
    UI_ctrl ui;
    Swipescreen swipe;
    [SerializeField] GameObject[] obj;
    string[] Zodiac = new string[12] { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };
    // Start is called before the first frame update
    void Start()
    {
        swipe = gameObject.GetComponent<Swipescreen>();
        System.DateTime today = System.DateTime.Today;
        switch (today.Month)
        {
            case 1:
                if (today.Day > 19)
                    zodiac = 1;
                else
                    zodiac = 0;
                break;
            case 2:
                if (today.Day > 19)
                    zodiac = 2;
                else
                    zodiac = 1;
                break;
            case 3:
                if (today.Day > 20)
                    zodiac = 3;
                else
                    zodiac = 2;
                break;
            case 4:
                if (today.Day > 20)
                    zodiac = 4;
                else
                    zodiac = 3;
                break;
            case 5:
                if (today.Day > 20)
                    zodiac = 5;
                else
                    zodiac = 4;
                break;
            case 6:
                if (today.Day > 20)
                    zodiac = 6;
                else
                    zodiac = 5;
                break;
            case 7:
                if (today.Day > 22)
                    zodiac = 7;
                else
                    zodiac = 6;
                break;
            case 8:
                if (today.Day > 22)
                    zodiac = 8;
                else
                    zodiac = 7;
                break;
            case 9:
                if (today.Day > 22)
                    zodiac = 9;
                else
                    zodiac = 8;
                break;
            case 10:
                if (today.Day > 22)
                    zodiac = 10;
                else
                    zodiac = 9;
                break;
            case 11:
                if (today.Day > 22)
                    zodiac = 11;
                else
                    zodiac = 10;
                break;
            case 12:
                if (today.Day > 21)
                    zodiac = 0;
                else
                    zodiac = 11;
                break;
        }
        Zodiac_Info.curr = Zodiac[zodiac];
        target = Instantiate(obj[zodiac], transform);
        anim = target.GetComponent<Animator>();
        ui = gameObject.GetComponent<UI_ctrl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                anim.SetTrigger("Start");
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Start");
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("STATE2"))
        {
            if(!ui.button.activeInHierarchy)
            ui.button.SetActive(true);
            swipe.ok1 = true;
        }
    }
}
