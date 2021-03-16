using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Number;
    public GameObject Player;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    public GameObject Player5;
    public GameObject Player6;
    public Text Number_text;
    public int a;

    // Start is called before the first frame update
    void Start()
    {
        NumberChange();
    }

    void NumberChange()
    {
        Number_text = Number.GetComponent<Text>();
        a = Random.Range(1, 7);
        Number_text.text = a.ToString();
        Player.gameObject.SetActive(false);
        if(a == 1)
        {
            Player1.gameObject.SetActive(true);
        }
        Player.gameObject.SetActive(false);
        if (a == 2)
        {
            Player2.gameObject.SetActive(true);
        }
        Player.gameObject.SetActive(false);
        if (a == 3)
        {
            Player3.gameObject.SetActive(true);
        }
        Player.gameObject.SetActive(false);
        if (a == 4)
        {
            Player4.gameObject.SetActive(true);
        }
        Player.gameObject.SetActive(false);
        if (a == 5)
        {
            Player5.gameObject.SetActive(true);
        }
        Player.gameObject.SetActive(false);
        if (a == 6)
        {
            Player6.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
