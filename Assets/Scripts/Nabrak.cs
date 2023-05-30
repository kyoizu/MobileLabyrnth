using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nabrak : MonoBehaviour
{
    [SerializeField] Text countdown;
    [SerializeField] GameObject Bola;
    [SerializeField] GameObject RetryMenu;

    public float timer = 20f;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("nabrak coy");
        Destroy(Bola);
        RetryMenu.SetActive(true);
    }

    private void Update() {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            countdown.text = (timer).ToString("0");
            return;
        }
        RetryMenu.SetActive(true);
        Destroy(Bola);
    }
}
