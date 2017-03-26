using UnityEngine;
using System.Collections;
using MidiJack;

// http://answers.unity3d.com/questions/423398/particle-burst-on-button-press.html

public class Emit_Script :  MonoBehaviour {

	public ParticleSystem particleSys;
	public string keyEvent;
	public int midiChannel;
	public int midiNote;
	public int numEmitParticles;
	public int minEmitParticles;
	public int maxEmitParticles;
    public AudioSource audioSource;

	void Start () {

		//particleSys = new ParticleSystem ();

		// You can use particleSystem instead of
		// gameObject.particleSystem.
		// They are the same, if I may say so
		particleSys.emissionRate = 0;
        Debug.Log("EMit Script Start");

    }

	void Update () {

		KeyCode kc = (KeyCode)System.Enum.Parse(typeof(KeyCode), keyEvent) ;

		if( Input.GetKeyDown( kc ) ) {
			particleSys.Emit(numEmitParticles);    
		}
	}

	void NoteOn(MidiChannel channel, int note, float velocity)
	{
		//Debug.Log("NoteOn: " + channel + "," + note + "," + velocity);

		if (velocity > 0 && midiNote == note ) {

			int nParticles = (int)Remap (velocity, 0f, 1.0f, (float)minEmitParticles, (float)maxEmitParticles);

			//Debug.Log("Emitting " + nParticles + " particles");

			particleSys.Emit (nParticles);
            audioSource.Play();
		}
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


	float Remap(float value, float from1, float to1, float from2, float to2) {
		return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
	}
}
