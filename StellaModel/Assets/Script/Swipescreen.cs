using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipescreen : MonoBehaviour
{
    Touch touch;
    public bool ok;
    public bool ok1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ok)
        {
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
                Quaternion q = Quaternion.Euler(0, touch.deltaPosition.x * .15f, 0);
                transform.rotation *= q;
            }
        }
        if (ok1)
        {
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
                Quaternion q = Quaternion.Euler(0, 0, touch.deltaPosition.x * .15f);
                transform.rotation *= q;
            }
        }
    }
}
