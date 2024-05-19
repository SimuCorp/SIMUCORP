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
        "Bienvenue dans notre tutoriel. Pour commencer, r�approvisionnez votre magasin. Pour ce faire, touchez une case contenant un produit, puis sel�ctionner avec les fl�ches du haut et du bas l'onglet quantit�, et enfin appuyer sur entrer pour r�aliser l'action souhait�e. Attention certains objets ne sont pas directement � votre disposition. Cependant vous pourrez les achet�s en cours de partie.",
        "Bien, de plus vous pouvez aussi modifier le prix et qualit� de vos produits. Pour changer d'options, utilisez les fl�ches verticales. Attention, appuyer sur entrer sur un menu contenant des fl�ches ne modifira pas la statistique correspondante. A la place appuyez sur les fl�ches lat�rales. Attention, en mode difficile vos produits p�rimeront tout les 3 tours.",
        "Maintenant, pour quitter le menu d'action et pour pouvoir vous d�placez � nouveau, appuyez sur la touche effacer de votre clavier.",
        "Bien jou� !!! De plus, vous pouvez acheter des am�liorations pour rendre votre magasin plus attractif. Pour ce faire, dirigez vous en direction d'un rectangle ayant une couleur diff�rente compar� au reste du d�cor.",
        "Comme vous pouvez le voir, cette fois-ci le texte est en rouge. Cela veux dire que vous n'avez pas assez d'argent pour faire cette action.",
        "Cependant, vous avez d'autres am�liorations comme le tableau de promotion, se trouvant vers l'entr�e du magasin.",
        "Vous avez aussi la possibilit� de faire des actions commerciales pour am�liorer votre attractivit�, ainsi vous aurez plus de clients. Ces actions sont disponibles � la table ayant un cadeau.",
        "Les derni�res actions possible se trouve � la caisse. Elles vous permettent la gestion de votre ou de vos magasins et de finir votre semaine de travail.",
        "Vous pouvez par exemple embaucher des employ�s, augmenter leur salaire ou leur donner des primes afin d'am�liorer la qualit� du magasin ou encore acheter de nouveau magasin pour avoir plus de clients. Cependant pour acheter un magasin il faut 5000 $ ainsi qu'au moins n-1 employ�s pour n magasins. Attention, vous devrez payer les salaires et vos impots ainsi que faire face � des �v�nements al�atoires toutes les 4 semaines.",
        "En compl�ment � cela, vouz pouvez mettre le jeu en pause en appuyant sur le touche espace de votre clavier. A l'int�rieur vous aurez la possibilit� de consult� les statiques li�s � vos produits ou services. Pour changer de produits appuyez sur les fl�ches lat�rales. Enfin pour quitter le menu pause faites r�appuyer sur la barre d'espace.",
        "Dans la m�me optique, vous pouvez aller sur le menu options en appuyant sur echap.",
        "Toutes les actions que vous ferez lors de votre aventure auront un impact sur votre score final. En effet, le score final est calcul� en fonction de vos ventes, de l'argent restant, de l'argent gagn�, des marchandises restantes, de votre nombre d'am�liorations, ainsi que de toutes vos autres statistiques.",
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
