using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PhoneSceneChange : MonoBehaviour
{
    
    public GameObject icon;
    
    void OnMouseDown()
    {

        if (icon.CompareTag("msgProf"))
            SceneManager.LoadScene("CellPhoneProfMsg");
        else if (icon.CompareTag("callProf"))
            SceneManager.LoadScene("CellPhoneProfCall");
        else if (icon.CompareTag("musicProf"))
            SceneManager.LoadScene("CellPhoneProfMusic");
        else if (icon.CompareTag("voiceAssi"))
        {
            Bgm.myAudioSource.Pause();
            SceneManager.LoadScene("CellPhoneAssiVoice");
        }
        else if (icon.CompareTag("msgAssi"))
            SceneManager.LoadScene("CellPhoneAssiMsg");
        else if (icon.CompareTag("musicAssi"))
            SceneManager.LoadScene("CellPhoneAssiMusic");

    }
}
