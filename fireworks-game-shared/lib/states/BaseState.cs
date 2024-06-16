using Microsoft.Xna.Framework;

namespace fireworks_game_shared.lib.states
{
    /**
     * BaseState class borrowed from:
    * GD50
    * Match-3 Remake
    * 
    * -- BaseState Class --
    * 
    * Author: Colton Ogden
    * cogden@cs50.harvard.edu
    * 
    * Provides a basic interface for all states to follow when used in a StateMachine or StateStack
    */
    public interface BaseState
    {
        void Enter(object parameters);

        void Exit();
        void Update(GameTime gameTime);

        void Draw(GameTime gameTime);
    }
}
