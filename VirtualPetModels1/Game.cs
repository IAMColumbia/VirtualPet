using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetModels1
{
    public abstract class Game
    {
        protected bool isPlaying;

        public virtual void Start()
        {
            //TODO make game here
            
        }

        public virtual void SetupGame()
        {
            this.isPlaying = false;
        }
    }
}