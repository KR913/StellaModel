using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Unity.Editor;
using Firebase.Database;
using Firebase.Extensions;

public class DB_init : MonoBehaviour
{
    public class infomation
    {
        public string content;
        public infomation(string b)
        {
            content = b;
        }
    }
    FirebaseDatabase db;
    DatabaseReference reference;
    // Start is called before the first frame update
    void Start()
    {
        Zodiac_Info.LoadFile();
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(Task =>
        {
            if (Task.Exception != null)
            {
                if (SceneManager.GetActiveScene().buildIndex != 0)
                {
                    SceneManager.LoadScene(0);
                }
                Zodiac_Info.LoadFile();
                return;
            }
            FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://stella-91382.firebaseio.com/");
            reference = FirebaseDatabase.DefaultInstance.RootReference;
            string[] Zodiac = new string[12] { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };
            for (int i = 0; i < 12; i++)
            {
                load(Zodiac[i]);
            }
        });
    }
    public void write(string zodiac, string content)
    {
        infomation info = new infomation(content);
        string json = JsonUtility.ToJson(info);
        Debug.Log(info);
        reference.Child(zodiac).SetRawJsonValueAsync(json);
    }
    public void load(string zodiac)
    {
        FirebaseDatabase.DefaultInstance
         .GetReference(zodiac)
         .GetValueAsync().ContinueWith(task => {
             if (task.IsFaulted)
             {
                 Debug.Log("Wrong Path");
             }
             else if (task.IsCompleted)
             {
                 DataSnapshot snapshot = task.Result;
                 Zodiac_Info.update(zodiac, snapshot.Child("content").Value.ToString());
                 Zodiac_Info.SaveFile();
             }
         });
    }
}
