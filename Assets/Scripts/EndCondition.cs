using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCondition : MonoBehaviour
{
    public GameObject puzzle;
    public GameObject winCondition;
    public Soundsfx soundsfx;
    public GameObject[] pos;

    [SerializeField]bool selesai = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!selesai)
        {
            CekPuzzle();
        }
    }

    public void CekPuzzle()
    {
        for(int i = 0; i < pos.Length; i++)
        {
            if (transform.GetChild(i).GetComponent<Dragdrop>().onTempel)
            {
                selesai = true;

            }
            else
            {
                selesai = false;
                i = pos.Length;
            }
        }

        if (selesai)
        {
            winCondition.SetActive(true);
            soundsfx.PlayVictory();
        }
    }
}
