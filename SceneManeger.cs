using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneScript : MonoBehaviour
{ 
    public float WaitTime;

     public void Load_ReloadScene(BaseEventData data)
    {
        StartCoroutine(GameScene(WaitTime));
    }
       public void Load_TitletScene(BaseEventData data)
    {
        StartCoroutine(TitleScene(WaitTime));
    }

    IEnumerator ReloadScene(float WaitTime)
    {
        Debug.Log("Gameをロード");
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene(SceneManager.GetActiveSene().name);
    }

        IEnumerator TitleScene(float WaitTime)
    {
        Debug.Log("Titleをロード");
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene("0_1_Title");
    }

    public void Quit(BaseEventData data)
    {
        Application.Quit();
    }

}