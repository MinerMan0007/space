using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

    public Transform level2enemise;
    private bool level2complete = true;
    public GameObject level2rewards;
    public EnemySpawner es;
    private int eneiesToSpawn = 3;
    private int wavecount=1;
    private int waveToWine = 3;
    public AudioSource music;
    public AudioClip wavemusic;
    public GameObject cutScene;


    // Use this for initialization
    protected void Start () {
        level2rewards.SetActive(false);
        music.Play();
        cutScene.SetActive(false);
        //spawnwave();
        

	}

	// Update is called once per frame
	protected void Update () {

        if (level2enemise.childCount == 0 &&level2complete)
        {
            level2rewards.SetActive(true);
            HUD.Message("all enimise are destroyed");

        }
        if(es.transform.childCount==0 && EnemySpawner.activated && !IsInvoking())
        {
            if (wavecount == 1)
            {
                music.clip = wavemusic;
                music.Play();
            }
            

            if (wavecount > waveToWine)
            {
                es.gameObject.SetActive(false);
                music.Stop();
                cutScene.SetActive(true);
                return;
            }

            HUD.Message("Wave" + "" + wavecount);
            wavecount++;
            eneiesToSpawn = Random.Range(wavecount*1,wavecount*2);
            Invoke("Spawnwave", 2);
        }

	}
    public void Spawnwave()
    {
        for (int i = 0; i < eneiesToSpawn; i++)
        {
            es.Invoke("Spawn", i);
        }
    }



}