using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public Text _namaSoal, ScoreTxt, Nilai;
    public Image _imageSoal;
    public AudioSource _audioSoal;
    public GameObject[] options;
    public int currentQuestion, score;
    public List<Question> KumpulanSoal;

    public GameObject QuizPanel;
    public GameObject GameOverPanel;
    public GameObject ScorePanel;
    public GameObject WinCondition;
    public GameObject LoseCondition;
    public Soundsfx soundsfx;

    private void Start()
    {
        _audioSoal = gameObject.GetComponent<AudioSource>();
        GameOverPanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        QuizPanel.SetActive(false);
        GameOverPanel.SetActive(true);
        ScorePanel.SetActive(false);
        Nilai.text = "" + score;
        ScoreTxt.text = "Nilai\n" + score;
        soundsfx.PlayVictory();
        if (score >= 60)
        {
            WinCondition.SetActive(true);
        }
        else
        {
            LoseCondition.SetActive(true);

        }
    }

    public void correct()
    {
        //Correct Answer
        score += 20;
        KumpulanSoal.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void wrong()
    {
        //Wrong Answer
        KumpulanSoal.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(.5f);
        generateQuestion();
    }

    void SetAnswer()
    {
        Scene scene = SceneManager.GetActiveScene();
        
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswerScript>().startColor;
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).gameObject.GetComponent<Text>().text = KumpulanSoal[currentQuestion].Answers[i];

            if (KumpulanSoal[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }

            
        }
        Nilai.text = "" + score;
    }

    void generateQuestion()
    {
        Scene scene = SceneManager.GetActiveScene();
 
        if(KumpulanSoal.Count > 0 )
        {
            if(scene.name == "Quiz Monas")
            {
                currentQuestion = Random.Range(0, KumpulanSoal.Count);
                _namaSoal.text = KumpulanSoal[currentQuestion].namaSoal;
            }
            else if (scene.name == "Quiz Prambanan")
            {
                currentQuestion = Random.Range(0, KumpulanSoal.Count);
                _namaSoal.text = KumpulanSoal[currentQuestion].namaSoal;
            }
            else if(scene.name == "Quiz Gadang")
            {
                currentQuestion = Random.Range(0, KumpulanSoal.Count);
                _namaSoal.text = KumpulanSoal[currentQuestion].namaSoal;
            }
            SetAnswer();
        }
        else
        {
            Debug.Log("Out of Question");
            GameOver();
        }
    }
}