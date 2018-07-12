using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerMenu : MonoBehaviour
{
    private static bool sPause = false;

    [Header("Settings")]
    [SerializeField] bool m_DontDestroyLoad = true;
    [SerializeField] KeyCode btPause = KeyCode.P;
    [SerializeField] GameObject panelPause;
    [Header("Observar")] [SerializeField] bool m_Pause;

    void Awake()
    {
        if (m_DontDestroyLoad) { DontDestroyOnLoad(gameObject); } //Evita que o Objeto seja destruido nas troca de cenas;
         if (panelPause) { panelPause.SetActive(false); }
    }

    // Use this for initialization
    void Start()
    {
        sPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        m_Pause = sPause;

        if (Input.GetKeyDown(btPause))
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name.Equals("Game"))
            {
                sPause = !sPause;

                if (sPause)
                {
                    Time.timeScale = 0f;
                    if (panelPause) { panelPause.SetActive(true); } else { print("GameObject panelPause == null"); }
                    
                    Cursor.visible = true;
                }
                else
                {
                    Time.timeScale = 1f;
                    if (panelPause) { panelPause.SetActive(false); } else { print("GameObject panelPause == null"); }
                    Cursor.visible = false;
                }
            }
        }
    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public static bool isPaused() { return sPause; }
}
