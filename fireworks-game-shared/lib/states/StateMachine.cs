using Microsoft.Xna.Framework;

namespace fireworks_game_shared.lib.states
{
    /**
     * StateMachine class borrowed from:
    * GD50
    * Match-3 Remake
    * 
    * -- StateMachine Class --
    * 
    * Author: Colton Ogden
    * cogden@cs50.harvard.edu
    * 
    * Allows for a game to track State and switch between states
    */
    public class StateMachine
    {
        private BaseState currentState;

        public StateMachine()
        {
        }

        public void ChangeState(BaseState nextState, object entryParameters)
        {
            if (this.currentState != null)
            {
                this.currentState.Exit();
            }
            this.currentState = nextState;
            this.currentState.Enter(entryParameters);
        }

        public void Update(GameTime gameTime)
        {
            this.currentState.Update(gameTime);
        }

        public void Draw(GameTime gameTime)
        {
            this.currentState.Draw(gameTime);
        }
    }
}
