using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldText : GameManager {
    
    private TextMeshProUGUI textMesh;

    void Awake() {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    void Update() {
        textMesh.text = "" + GameManager.instance.gold;
    }
}
