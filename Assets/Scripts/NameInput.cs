using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class NameInput : MonoBehaviour

   
{

    public static NameInput Instance;
    public string PlayerName;

    private void Awake()
    {
        /* if (Instance != null)
         {
             Destroy(gameObject);
             return;
         } */
        Instance = this;
        // DontDestroyOnLoad(gameObject);

    }

    // Start is called before the first frame update



    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(SaveName);
        // SaveName();
    }


    public void SaveName(string arg)
    {

        Debug.Log(arg);
        PlayerName = arg;
        
    }
}
