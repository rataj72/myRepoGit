using System;

namespace s
{
    public abstract class Handler
    {
        protected Handler Succesor;

        public void SetSuccesor(Handler succesor)
        {
            this.Succesor = succesor;
        }

        public abstract void MoveH(object sender);

    }
}