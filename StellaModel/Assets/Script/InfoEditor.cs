using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoEditor : MonoBehaviour
{
    [SerializeField] InputField inp;
    DB_init db;
    // Start is called before the first frame update
    void Start()
    {
        db = gameObject.GetComponent<DB_init>();
        inp.text = Zodiac_Info.info();
    }
    public void confirm()
    {
        db.write(Zodiac_Info.curr, inp.text);
        db.load(Zodiac_Info.curr);
        SceneManager.LoadScene("ReWrite");
    }
    public void cancel()
    {
        SceneManager.LoadScene("ReWrite");

    }
}
