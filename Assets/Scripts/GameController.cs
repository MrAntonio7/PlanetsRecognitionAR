using System.Collections;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text countdownText;

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        // Mostrar el contador durante 3 segundos
        for (int i = 3; i > 0; i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }

        // Después de contar hasta 0, oculta el texto y comienza el juego
        countdownText.text = "GO!";
        yield return new WaitForSeconds(1f);
        countdownText.gameObject.SetActive(false);
    }
}