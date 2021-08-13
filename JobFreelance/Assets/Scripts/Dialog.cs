using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject dialogBox;
    public GameObject continueButton;
    public bool PlayerInRange;

    void Start(){

        StartCoroutine(Type());
        
    }

    void Update(){

        if(textDisplay.text == sentences[index]){
            dialogBox.SetActive(true);
            continueButton.SetActive(true);

        }
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerInRange = true;
        }

    }

    private void OnTriggerExit2D (Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerInRange = false;
        }
    }

    IEnumerator Type(){
        
        foreach(char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence(){

        continueButton.SetActive(false);

        if(index < sentences.Length - 1){
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else{
            textDisplay.text = "";
            continueButton.SetActive(false);
            dialogBox.SetActive(false);
        }
    }
}
