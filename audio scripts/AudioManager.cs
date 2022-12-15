

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioSource> music; //The list of tracks
    public int currentTrack = 0; //The starting track

    // Start is called before the first frame update
    void Start()
    {
        music[0].Play(); //The first song plays when the scene is loaded
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3)) //The button is pressed
        {
            music[currentTrack].Stop(); //The current track stops 
            nextTrack(); //The next track is loaded
            music[currentTrack].Play(); //The new track is played
        }

        //if (Input.GetKeyDown(KeyCode.X))
        //{
        //    playPause();
        //}

        if (!music[currentTrack].isPlaying)
        {
            nextTrack(); //The next track is loaded
            music[currentTrack].Play(); //The new track is played
        }
    }

    void nextTrack()
    {
        currentTrack++; //The playlist is changed by one
        if (currentTrack >= music.Count)
        {
            currentTrack = 0; //If the playlist number is higher than the number of songs in the playlist it will automatically repeat the playlist
        }
    }

    void playPause()
    {
        if (music[currentTrack].isPlaying)
        {
            music[currentTrack].Pause(); //The current song is paused
        }
        else
        {
            music[currentTrack].UnPause(); //The current song resumes
        }
    }
}