using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {
    public int dateNum;

    void Start() {
        DontDestroyOnLoad(this.gameObject); //This is necessary to ensure the HUD carries between scenes.
    }

    public void dateUp() {
        dateNum += 1;
    }
}