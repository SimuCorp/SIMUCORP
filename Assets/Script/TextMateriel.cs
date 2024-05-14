using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using static MoneyCount;
using static PlayerScript;
public class TextMateriel : MonoBehaviour
{
    public int n;
    public TextMeshProUGUI Text;
    
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
    
            g = Gamer1;

        string res = g.materiel[n];
        Text.text = $"{res}\n\n {2500}";
    }
}
