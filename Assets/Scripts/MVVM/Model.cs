using System;

namespace JetUnity.MVVM
{
    public abstract class Model : IDisposable
    {
        protected Model() { }

        public void Dispose() => OnDispose();
        protected virtual void OnDispose() { }
    }

}
