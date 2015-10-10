using UnityEngine;
using System.Collections;
using System.Text;

public class GameManager : MonoBehaviour {




	// Use this for initialization
	void Start () {
		Debug.Log("GameManager->Start");
		state = State.MainMenu;
	}
	
	// Update is called once per frame
	void Update () {
		runState();
	}

	#region State Machine System
	enum State{
		Unknown,
		MainMenu,
		Pause,
		Day,
		NextWave,
		Wave,
		GameOver,
	};
	State _state;
	State state { get { return _state;}
		set {
			State previousState = _state;
			State nextState = value;
			Debug.Log(string.Format("GameManager->[toState: {0}] [fromState: {1}]", nextState, previousState));
			endState (nextState);
			_state = value;
			beginState (previousState);
		}}
	void runState(){
		switch (state) {
		default:
			Debug.Assert(true, "invalid state");
			break;
		case State.MainMenu:
			MainMenu();
			break;
		case State.Wave:
			Wave();
			break;
		case State.NextWave:
			NextWave();
			break;
		case State.Day:
			Day ();
			break;
		case State.GameOver:
			GameOver();
			break;
		case State.Pause:
			Pause ();
			break;
		}
	}
	void endState(State nextState){
		switch (state) {
		default:
			break;
		case State.MainMenu:
			MainMenuEnd(nextState);
			break;
		case State.Wave:
			WaveEnd(nextState);
			break;
		case State.NextWave:
			NextWaveEnd(nextState);
			break;
		case State.Day:
			DayEnd(nextState);
			break;
		case State.GameOver:
			GameOverEnd(nextState);
			break;
		case State.Pause:
			PauseEnd(nextState);
			break;
		}
	}
	void beginState(State previousState){
		switch (state) {
		default:
			Debug.Assert(true, "invalid state");
			break;
		case State.MainMenu:
			MainMenuBegin(previousState);
			break;
		case State.Wave:
			WaveBegin(previousState);
			break;
		case State.NextWave:
			NextWaveBegin(previousState);
			break;
		case State.Day:
			DayBegin(previousState);
			break;
		case State.GameOver:
			GameOverBegin(previousState);
			break;
		case State.Pause:
			PauseBegin(previousState);
			break;
		}
	}
	#endregion

	#region MainMenu State Machine Implementation
	void MainMenuBegin(State previousState) {
	}
	void MainMenu() {
		state = State.Day;
	}
	void MainMenuEnd(State nextState) {
	}
	#endregion

	#region Pause State Machine Implementation
	void PauseBegin(State previousState) {
	}
	void Pause() {
	}
	void PauseEnd(State nextState) {
	}
	#endregion

	#region Day State Machine Implementation
	void DayBegin(State previousState) {
	}
	void Day() {
	}
	void DayEnd(State nextState) {
	}
	#endregion

	#region Pause State Machine Implementation
	void NextWaveBegin(State previousState) {
	}
	void NextWave() {
	}
	void NextWaveEnd(State nextState) {
	}
	#endregion

	#region Pause State Machine Implementation
	void WaveBegin(State previousState) {
	}
	void Wave() {
	}
	void WaveEnd(State nextState) {
	}
	#endregion

	#region Pause State Machine Implementation
	void GameOverBegin(State previousState) {
	}
	void GameOver() {
	}
	void GameOverEnd(State nextState) {
	}
	#endregion
}
