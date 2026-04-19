using System.Collections;
using UnityEngine;
using TMPro;

public class SystemeIA : MonoBehaviour
{
    [Header("Références AR")]
    public TextMeshProUGUI texteAR;
    public GameObject modele3D;

    // ✅ Cette méthode doit être PUBLIC pour que le bouton puisse l'appeler
    public void LancerAnalyse()
    {
        StartCoroutine(SimulerIA());
    }

    private IEnumerator SimulerIA()
    {
        // Étape 1 : Détection
        texteAR.text = "🔍 Détection des points de forme...";
        yield return new WaitForSeconds(1.5f);

        // Étape 2 : Comparaison
        texteAR.text = "⚙️ Comparaison avec la base de données...";
        yield return new WaitForSeconds(1.5f);

        // Étape 3 : Résultat
        texteAR.text = "🚀 Objet : Fusée Saturn V\n" +
                       "📡 Mission : Apollo 11\n" +
                       "📏 Hauteur : 110.6 m\n" +
                       "⚡ Poussée : 34,5 MN";
    }
}