using UnityEngine;

	public abstract class StateController : MonoBehaviour
	{
		public State currentState;
		public float currentStateTime;
		protected bool freeze;
		private float timeIsFreezing;
			
		
		public void Update()
		{
			
				currentState.UpdateState(this);
				currentStateTime += Time.deltaTime;
			
			
		}

		public void TransitionToState(State nextState)
		{
			if (currentState == nextState)
				return;

			currentStateTime = 0;
			currentState = nextState;
		}

		
	}