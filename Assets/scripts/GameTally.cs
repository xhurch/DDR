using UnityEngine;
using MidiJack;
using System.Collections;

public class Tally {

	public int count;
	public int note;
	public MidiChannel channel;

	public Tally()
	{
		count = 0;
		note = 0;
		channel = MidiChannel.Ch1;
	}

	public void Increment(){

		count++;

		//Debug.Log ("Note " + note + ": " + count);
	}

	public void Reset(){

		count = 0;
	}
}

public class GameTally : MonoBehaviour
{

	public Tally[] emojiTally;

	GameTally(){

		emojiTally = new Tally[6];

		for (int i = 0; i < 6; i++) {
			emojiTally [i] = new Tally ();
		}

		emojiTally[0].note = 35;
		emojiTally[1].note = 36;
		emojiTally[2].note = 37;
		emojiTally[3].note = 38;
		emojiTally[4].note = 39;
		emojiTally[5].note = 40;
	}

	void NoteOn(MidiChannel channel, int note, float velocity)
	{
		Debug.Log("NoteOn: " + channel + "," + note + "," + velocity);

		for (int i = 0; i < 6; i++) {
			if (emojiTally [i].note == note) {
				emojiTally [i].Increment ();

			}
		}
	}

	void Reset(){

		for (int i = 0; i < 6; i++) {
			emojiTally [i].Reset ();
		}
	}

	void OnEnable()
	{
		MidiMaster.noteOnDelegate += NoteOn;
	}

	void OnDisable()
	{
		MidiMaster.noteOnDelegate -= NoteOn;
	}
}
