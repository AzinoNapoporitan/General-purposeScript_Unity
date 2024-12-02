using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneScript : MonoBehaviour
{ 
    public void DelayLoad_GameScene()
    {
        Debug.Log("ロードすると思う");
        Invoke("Load_GameScene",2.0f);
    }

     public void Load_GameScene(BaseEventData data)
    {
        SceneManager.LoadScene("1_1_Game");
    }

    public void Load_TitleScene(BaseEventData data)
    {
        SceneManager.LoadScene("0_1_Title");
    }

    public void Quit(BaseEventData data)
    {
        Application.Quit();
    }

  
}
