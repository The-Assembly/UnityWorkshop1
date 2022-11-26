using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // adding this namespace to start using scene management and changing scenes
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class FinishLine : MonoBehaviour
{
public Text levelText;
private string test;
// Start is called before the first frame update
void Start()
{
levelText = GameObject.Find("LevelCount").GetComponent<Text>();
Debug.Log(levelText);

levelText.text = "Loop: " + LevelCount.GetCount().ToString();
}

// Update is called once per frame
void Update()
{

}

public void OnTriggerEnter2D(Collider2D other)
{
if (other.gameObject.CompareTag("Player"))
{
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // .sceneCount + 1);
LevelCount.SetCount(LevelCount.GetCount() + 1);

Debug.Log("Timer initialized!!");
}
}
}