using UnityEngine;
using System.Collections;
using MidiJack;

// http://answers.unity3d.com/questions/423398/particle-burst-on-button-press.html

public class MIDIDebug : MonoBehaviour
{


    void Start()
    {


    }

    void Update()
    {

      
    }

    void NoteOn(MidiChannel channel, int note, float velocity)
    {
       Debug.Log("NoteOn: " + channel + "," + note + "," + velocity);

        
    }

    void OnEnable()
    {
        MidiMaster.noteOnDelegate += NoteOn;
        //MidiMaster.noteOffDelegate += NoteOff;
        //MidiMaster.knobDelegate += Knob;
    }

    void OnDisable()
    {
        MidiMaster.noteOnDelegate -= NoteOn;
        //MidiMaster.noteOffDelegate -= NoteOff;
        //MidiMaster.knobDelegate -= Knob;
    }
}
