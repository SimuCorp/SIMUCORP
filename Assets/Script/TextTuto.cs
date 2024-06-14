using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
using UnityEngine.SceneManagement;
using System.Threading;
using Mirror;
using static System.Math;
using static PlayerScript;
using static Player1Script;
using static TextActionJoueur1;

public class TextTuto : NetworkBehaviour
{
    public Text Info;
    public static int i;
    public bool joueur1;
    [SerializeField] private GameObject Tuto1;
	[SerializeField] private GameObject Tuto2;
    [SerializeField] private GameObject Money1;
	[SerializeField] private GameObject Money2;
    [SerializeField] private GameObject FinDeTour;
    [SerializeField] private GameObject Accueil;
    public Animator fondu;
    public static List<string> Script = new List<string> {
        "Bienvenue dans notre tutoriel.",
        "Pour réapprovisionner :\n\n\t- touchez la case du produit.\n\t- sélectionnez le menu quantité par \u2191 ou \u2193.\n\t- appuyez sur entrée.",
        "Attention, certains produits ne sont pas disponibles immédiatement.", // 2
        "Attention, en mode difficile, les produits périmeront tous les trois tours.", // 3
        "Pour modifier le prix ou la qualité :\n\n\t- sélectionnez le menu correspondant avec ⬆\u2191 ou \u2193.\n\t- appuyez sur entrée pour le menu qualité.\n\t- modifiez les paramètres de prix avec <- ou ->.",
        "Pour quitter le menu, appuyez sur la touche effacer.", // 5
        "Pour augmenter l'attractivité, afin d'avoir plus de clients et diminuer celle de l'adversaire :\n\n\t-allez vers la table à l'entrée.\n\t- appuyez sur entrée.", // 6
        "Pour faire des promotions et augmenter temporairement votre attractivité :\n\n\t- allez vers le trait noir sur le trottoir.\n\t- appuyez sur entrée pour acheter le tableau de promotion.\n\t- appuyez sur entrée pour l'activer ou le désactiver.",
        "Pour acheter d'autres améliorations augmentant définitivement l'attractivité :\n\n\t- allez vers les cases ayant une couleur différente par rapport au décor.\n\t- appuyez sur entrée pour les acheter.\n\nAttention, les textes en rouge indiquent que l'on ne peut pas réaliser l'action souhaitée.",
        "Pour la gestion du nombre de salariés :\n\n\t- allez à la caisse.\n\t- sélectionnez le menu correspondant avec \u2191 ou \u2193.\n\t- appuyez sur <- ou -> afin de changer le nombre d'employés.\n\t- le nombre d'employés joue sur la qualité générale du magasin. Cette statistique est utilisée à la fin de la partie pour calculer le score final, tout comme vos autres statistiques.",
        "Attention, renvoyer un employé coûte 700 $ et vous devrez payer vos employés tous les quatre tours.",
        "Pour augmenter la qualite générale de votre magasin :\n\n\t- sélectionnez l'onglet prime\n\t- appuyez sur entrée pour valider l'action.",
        "Pour la gestion des magasins :\n\n\t- sélectionnez le menu correspondant avec \u2191 ou \u2193.\n\t- appuyez sur <- ou -> afin de changer le nombre d'employés.\n\nAttention, pour acheter un magasin, il faut avoir 5 000 $ et avoir au moins n employés pour n+1 magasin. Par exemple, pour acheter un troisième magasin, il vous faut au moins deux employés. Vendre un magasin rapporte 2 500 $.",
        "Pour allez sur le menu options, en cours de partie, appuyez sur échap. Pour en sortir, faites de même.",
        "De façon similaire, appuyez sur la barre d'espace pour mettre en pause le jeu. Vous pourrez consulter les statistiques de vos produits ou services, ainsi que ceux de votre adversaire avec <- ou ->.",
        "Pour finir votre tour :\n\n\t- sélectionnez finir son tour avec \u2191 ou \u2193.\n\t- appuyez sur entrée.",
                                                           };
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        Info = GetComponent<Text>();
        double x = Info.transform.position.x;
		double x2 = Screen.width/2;
        //if (!NetworkServer.active || x <= x2)
            Info.text = Script[0];
        /*
        else
            Info.text = "";
        */
    }
    IEnumerator attend2()
    {
        fondu.Play("fin_tour");
        yield return new WaitForSeconds(1);
        Tuto1.SetActive(false);
        Tuto2.SetActive(false);
        FinDeTour.SetActive(false);
		Accueil.SetActive(true);
 
    }
    // Update is called once per frame
    void Update()
    {
        Player1Script.timecol = 130;
        double x = Info.transform.position.x;
		double x2 = Screen.width/2;
        PlayerClass gamer;
        if (NetworkServer.active)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        if(TourCount.TurnValues >= 2)
        {
            Money1.SetActive(false);
            Money2.SetActive(false);
            StartCoroutine("attend2");
            Gamer1 = new Primeur("Primeur");
	        Gamer2 = new Boucherie("Boucher");
            TourCount.TurnValues = 1;
            i = 0;
            Info.text = Script[i];
            AI = null;
        }
        switch(i)
        {
            case(0):
                if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                Info.text = Script[i];
                break;
            case(1):
                
                Info.text = Script[i];
                  int j = 0;
                (int q, _, _, _, _) = gamer._marchandise[gamer._items[j]];
                while (j < 11 &&  q == 300)
                {
                    ++j;
                    if (gamer._items[j] != "NaN")
                        (q, _, _, _, _) = gamer._marchandise[gamer._items[j]];
                }
                if (q != 300 && q != 0)
                {
                    Info.text = Script[1];
                    ++i;
                }
                break;
            case(2):
                if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                Info.text = Script[i];
                break;
            case(3):
                if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
                break;
            case(4):
                if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
              
                break;
            case(5):
                if (Input.GetKeyDown(KeyCode.Backspace))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
              
                break;
            case(6):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                Info.text = Script[i];
                break;
            case(7):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
     
                break;
            case(8):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
                break;
            case(9):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];

                break;
            case(10):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
           
                break;
            case(11):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
                break;
            case(12):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
                break;
            case(13):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
                break;
            case(14):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                else if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
                break;
            case(15):
                if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                {
                    --i;
                    Info.text = Script[i];
                }
                if(TourCount.TurnValues >= 2)
                {
                    Money1.SetActive(false);
                    Money2.SetActive(false);
                    StartCoroutine("attend2");
                    Gamer1 = new Primeur("Primeur");
	                Gamer2 = new Boucherie("Boucher");
                    TourCount.TurnValues = 1;
                    i = 0;
                    Info.text = Script[i];
                    AI = null;
                }
                break;
            default:
                break;
        }
    }
}
