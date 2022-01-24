using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class SceneChange : MonoBehaviour 
{

    
    public void Idle()
    {
        transform.position = transform.position;
    }

    public void RoomAssi()
    {
        Idle();
        PlayerPrefs.SetInt("Assi", 1);
        SceneManager.LoadScene ("RoomAssistant");
    }

    public void RoomProf()
    {
        Idle();
        SceneManager.LoadScene("RoomProfessor");
    }

    public void RoomG()
    {
        Idle();
        PlayerPrefs.SetInt("Guard", 1);
        SceneManager.LoadScene("RoomGuard");
    }

    public void RoomCoW()
    {
        Idle();
        PlayerPrefs.SetInt("CoW", 1);
        SceneManager.LoadScene("RoomCoWorker");
    }

    public void PhoneProf()
    {
        Idle();
        SceneManager.LoadScene("CellPhoneProfMain");
    }

    public void PhoneProfMsg()
    {
        Idle();
        SceneManager.LoadScene("CellPhoneProfMsg");
    }

    public void PhoneAssi()
    {
        Idle();
        SceneManager.LoadScene("CellPhoneAssiMain");
    }

    public void CoWCom()
    {
        Idle();
        SceneManager.LoadScene("CoWCompuerLock");
    }

    public void FindCriminal()
    {
        Idle();
        Bgm.myAudioSource.Pause();
        SceneManager.LoadScene("FindCrime");
    }

    public void HowtoPlay()
    {
        Idle();
        SceneManager.LoadScene("HowToPlay");
    }

    public void GoToMain()
    {
        Idle();
        Bgm.myAudioSource.Pause();
        SceneManager.LoadScene("GameMain");
    }

    public void GoToOutside()
    {
        Idle();
        SceneManager.LoadScene("OutOfWindow");
    }

    public void Checkguns()
    {
        Idle();
        SceneManager.LoadScene("CheckGuns");
    }

    

    public GameObject preEvidence, nextEvidence;
    
    public void nEvidence()
    {
        preEvidence.SetActive(false);
        nextEvidence.SetActive(true);
    }

    public GameObject plane;
    public GameObject startPanel;

    public void profNecro()
    {
        plane.SetActive(false);
    }

    public void fail()
    {
        SceneManager.LoadScene("Fail");
    }

    public void success()
    {
        SceneManager.LoadScene("Success");
    }

    public void hideStartPanel()
    {
        startPanel.SetActive(false);
    }
    void OnMouseDown()
    {
        if (plane.CompareTag("backAssiV"))
        {
            Idle();
            Bgm.myAudioSource.Play();
            SceneManager.LoadScene("CellPhoneAssiMain");
        }
        else if (plane.CompareTag("backAssi"))
        {
            Idle();
            SceneManager.LoadScene("CellPhoneAssiMain");
        }
        else if (plane.CompareTag("backProf"))
        {
            Idle();
            SceneManager.LoadScene("CellPhoneProfMain");
        }
        else if (plane.CompareTag("backAssiRoom"))
        {
            Idle();
            SceneManager.LoadScene("RoomAssistant");
        }
        else if (plane.CompareTag("backProfRoom"))
        {
            Idle();
            SceneManager.LoadScene("RoomProfessor");
        }
        else if (plane.CompareTag("backGuardRoom"))
        {
            Idle();
            SceneManager.LoadScene("RoomGuard");
        }
        else if (plane.CompareTag("backCoWRoom"))
        {
            Idle();
            SceneManager.LoadScene("RoomCoWorker");
        }
        else if (plane.CompareTag("CoWComInternet"))
        {
            Idle();
            SceneManager.LoadScene("CoWComputerMail");
        }

    }
}
