using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishState : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject scoreboard;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Goal");
        scoreboard.SetActive(true);
    }
}
