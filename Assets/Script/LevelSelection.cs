using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void lvlToPlay(int lvlSelected)
    {
        PlayerPrefs.SetInt("LvlToPlay",lvlSelected);

    }

   public void load()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("LvlToPlay"));

    }

   public void pass()
    {
         StartCoroutine(loadNext());
        

    }

    public IEnumerator loadNext()
  {
      yield return new WaitForSeconds(0.7f);
      int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if(currentLevel>=PlayerPrefs.GetInt("levelUnlocked"))
        {
            PlayerPrefs.SetInt("levelUnlocked",currentLevel+1);
        }
        SceneManager.LoadScene(currentLevel+1);
      
  }
        
    
}
