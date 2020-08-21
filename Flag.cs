using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject startUI;
    private bool start = false;
    private float Startscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start&&!GameManager.instance.isGameover)
        {
            Startscore += Time.deltaTime;
            GameManager.instance.AddScore((int)Startscore);
            
        }

    }

    public void StartUI()
    {
        startUI.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            start = true;
            startUI.SetActive(true);
            Invoke("StartUI", 1f);
        }
    }
}
