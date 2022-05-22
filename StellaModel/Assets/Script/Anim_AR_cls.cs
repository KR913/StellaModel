using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Anim_AR_cls : MonoBehaviour, ITrackableEventHandler
{
    TrackableBehaviour mTrackableBehaviour;
    [SerializeField] Animator anim;
    [SerializeField] string Zname;
    [SerializeField] UI_ctrl ui;
    Transform child;
    bool ok = false;

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
        newStatus == TrackableBehaviour.Status.TRACKED ||
        newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            ok = true;
            Zodiac_Info.curr = Zname;
        }
        else
        {
            if (ok)
            {
                ok = false;
                anim.SetTrigger("Reset");
                Zodiac_Info.curr = "";
                ui.info.SetActive(false);
                ui.button.SetActive(false);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        child = transform.GetChild(0);
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ok)
        {
            if (Input.touchCount>0)
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
                ui.button.SetActive(true);
            }

        }        
    }
}
