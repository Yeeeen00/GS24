using UnityEngine;

namespace Match3
{
    public class LevelSelect : MonoBehaviour
    {
        [System.Serializable]
        public struct ButtonPlayerPrefs
        {
            public GameObject gameObject;
            public string playerPrefKey;
        };

        public ButtonPlayerPrefs[] buttons;

        private void Start()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].gameObject != null)
                {
                    int score = PlayerPrefs.GetInt(buttons[i].playerPrefKey, 0);

                    for (int starIndex = 1; starIndex <= 3; starIndex++)
                    {
                        Transform star = buttons[i].gameObject.transform.Find($"star{starIndex}");
                        if (star != null && star.gameObject != null)
                        {
                            star.gameObject.SetActive(starIndex <= score);
                        }
                        else
                        {
                            Debug.LogWarning($"Star{starIndex} not found for button {buttons[i].gameObject.name}");
                        }
                    }
                }
                else
                {
                    Debug.LogWarning($"Button {i} is null.");
                }
            }
        }

        public void OnButtonPress(string levelName)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);
        }
    }
}
