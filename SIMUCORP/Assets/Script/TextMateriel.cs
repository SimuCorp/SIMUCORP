using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
using static PlayerScript;
public class TextMateriel : NetworkBehaviour 
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
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        string res = g.materiel[n];
        Text.text = $"{res}\n\n {2500}";
    }
}
