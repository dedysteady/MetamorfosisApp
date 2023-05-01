using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Transform loadingBar;

    [SerializeField]
    private float value;
    [SerializeField]
    private float valueBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (value < 100)
        {
            value += valueBar * Time.deltaTime;
            Debug.Log((int)value);
        }
        else
        {
            Application.LoadLevel("Menu Utama");
        }
        loadingBar.GetComponent<Image>().fillAmount = value / 100;
    }
}
