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
    [SerializeField] private GameObject Accueil;
    public static List<string> Script = new List<string> {
        "Bienvenue dans notre tutoriel. Pour commencer, réapprovisionnez votre magasin. Pour ce faire, touchez une case contenant un produit, puis seléctionner avec les flèches du haut et du bas l'onglet quantité, et enfin appuyer sur entrer pour réaliser l'action souhaitée. Attention certains objets ne sont pas directement à votre disposition. Cependant vous pourrez les achetés en cours de partie.",
        "Bien, de plus vous pouvez aussi modifier le prix et qualité de vos produits. Pour changer d'options, utilisez les flèches verticales. Attention, appuyer sur entrer sur un menu contenant des flèches ne modifira pas la statistique correspondante. A la place appuyez sur les flèches latérales. Attention, en mode difficile vos produits périmeront tout les 3 tours.",
        "Maintenant, pour quitter le menu d'action et pour pouvoir vous déplacez à nouveau, appuyez sur la touche effacer de votre clavier.",
        "Bien joué !!! De plus, vous pouvez acheter des améliorations pour rendre votre magasin plus attractif. Pour ce faire, dirigez vous en direction d'un rectangle ayant une couleur différente comparé au reste du décor.",
        "Comme vous pouvez le voir, cette fois-ci le texte est en rouge. Cela veux dire que vous n'avez pas assez d'argent pour faire cette action.",
        "Cependant, vous avez d'autres améliorations comme le tableau de promotion, se trouvant vers l'entrée du magasin.",
        "Vous avez aussi la possibilité de faire des actions commerciales pour améliorer votre attractivité, ainsi vous aurez plus de clients. Ces actions sont disponibles à la table ayant un cadeau.",
        "Les dernières actions possible se trouve à la caisse. Elles vous permettent la gestion de votre ou de vos magasins et de finir votre semaine de travail.",
        "Vous pouvez par exemple embaucher des employés, augmenter leur salaire ou leur donner des primes afin d'améliorer la qualité du magasin ou encore acheter de nouveau magasin pour avoir plus de clients. Cependant pour acheter un magasin il faut 5000 $ ainsi qu'au moins n-1 employés pour n magasins. Attention, vous devrez payer les salaires et vos impots ainsi que faire face à des évènements aléatoires toutes les 4 semaines.",
        "En complément à cela, vouz pouvez mettre le jeu en pause en appuyant sur le touche espace de votre clavier. A l'intérieur vous aurez la possibilité de consulté les statiques liés à vos produits ou services. Pour changer de produits appuyez sur les flèches latérales. Enfin pour quitter le menu pause faites réappuyer sur la barre d'espace.",
        "Dans la même optique, vous pouvez aller sur le menu options en appuyant sur echap.",
        "Toutes les actions que vous ferez lors de votre aventure auront un impact sur votre score final. En effet, le score final est calculé en fonction de vos ventes, de l'argent restant, de l'argent gagné, des marchandises restantes, de votre nombre d'améliorations, ainsi que de toutes vos autres statistiques.",
        "Pour conclure ce tutoriel, finissez votre tour."
                                                           };
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        Info = GetComponent<Text>();
        double x = Info.transform.position.x;
		double x2 = Screen.width/2;
        //if (!this.isServer || x <= x2)
            Info.text = Script[0];
        /*
        else
            Info.text = "";
        */
    }

    // Update is called once per frame
    void Update()
    {
        double x = Info.transform.position.x;
		double x2 = Screen.width/2;
        PlayerClass gamer;
        if (this.isServer)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        switch(i)
        {
            case(0):
                int j = 0;
                (int q, _, _, _, _) = gamer._marchandise[gamer._items[j]];
                while (j < 11 &&  q == 300)
                {
                    ++j;
                    if (gamer._items[j] != "NaN")
                        (q, _, _, _, _) = gamer._marchandise[gamer._items[j]];
                }
                if (q != 300)
                {
                    Info.text = Script[1];
                    ++i;
                }
                break;
            case(1):
                if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                Info.text = Script[i];
                break;
            case(2):
                if (Input.GetKeyDown(KeyCode.Backspace))
                    ++i;
                if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
                break;
            case(3) when TextActionJoueur1.action.text.Contains("2500 $"):
                ++i;
                Info.text = Script[i];
                break;
            case(4):
                if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                Info.text = Script[i];
              
                break;
            case(5):
                if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
              
                break;
            case(6):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
          
                break;
            case(7):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
     
                break;
            case(8):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
                break;
            case(9):
                if(Input.GetKeyDown(KeyCode.Space))
                    ++i;
                if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];

                break;
            case(10):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                     ++i;
                Info.text = Script[i];
           
                break;
            case(11):
                if(Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
                    ++i;
                if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                    --i;
                Info.text = Script[i];
                break;
            case(12):
                if(Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha6))
                {
                    --i;
                    Info.text = Script[i];
                }
                if(TourCount.TurnValues >= 2)
                {
                    Tuto1.SetActive(false);
                    Tuto2.SetActive(false);
                    Money1.SetActive(false);
                    Money2.SetActive(false);
                    Accueil.SetActive(true);
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
