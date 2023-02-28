using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class buttonAction : MonoBehaviour
{
   public  AudioSource audioData;
   public AudioClip[] audioClipArray;
   public bool play = false;
   public bool[] arr;
    // Start is called before the first frame update
    void Awake(){
        audioData = GetComponent<AudioSource>();
    }
    void Start()
    {
        
        //audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reproduzAudio(string audio ){
        
        int number = 0;
        for(int i = 0; i<audioClipArray.Length;i++){
            Debug.Log(audioClipArray[i]);
            if(audioClipArray[i].name == audio){
                number = i;
audioData.clip = audioClipArray[i];
            }
        }
        Debug.Log(arr[number]);
        if(!arr[number] ){
            Debug.Log("play"+audioClipArray[number].name);
            
            for(int i = 0; i<audioClipArray.Length;i++){
          
            if(arr[i]){
               arr[i] = false;

 audioData.Stop();
            }
            
 audioData.Stop();
        }arr[number] = true;
            Debug.Log(arr[number]);
            audioData.PlayOneShot(audioData.clip);
//audioData.Play(0);


        }else{
             Debug.Log("stop"+audioClipArray[number].name);
            //audioData.Stop();
            audioData.Stop();
            arr[number] = false;
        }

    }
}
