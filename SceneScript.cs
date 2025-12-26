using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneScript : MonoBehaviour
{
    private string _SceneName;
    private int _WaitTime;
    
    public void SettingSeneName(string ScenenName)
    {
        _SceneName = ScenenName;
    }
    public void SettingWaitTime(int waitTime)
    {
        _WaitTime = waitTime;
    }
    //次のシーンへ　※上記二つを設定する必要があります※
    public void NextScene()
    {
        StartCoroutine(TitleScene(_SceneName,_WaitTime));
    }
    //リスタート
    public void ReloadScene(float waitTime)
    {
        StartCoroutine(_ReloadScene(WaitTime));
    }
    //ゲーム終了
    public void Quit(BaseEventData data)
    {
        Application.Quit();
    }
    

     IEnumerator _NextScene(string ScenenName, int waitTime)
    {
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene(ScenenName);
    }

        IEnumerator _ReloadScene(float WaitTime)
    {
        Debug.Log("Gameをロード");
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene(SceneManager.GetActiveSene().name);
    }

    
}
