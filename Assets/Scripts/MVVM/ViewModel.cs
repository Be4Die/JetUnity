using UnityEngine;

namespace JetUnity.MVVM
{
    public class ViewModel <M, V> : MonoBehaviour
        where M : Model
        where V : View
    {
        protected M m_model;
        protected V m_view;

        public void Bind(M model)
        {
            if (m_model != null)
                Unbind();

            m_model = model;
            OnBind();
        }

        public void Unbind()
        {
            if (m_model == null)
                return;

            OnUnbind();
        }

        protected virtual void OnBind() { }
        protected virtual void OnUnbind() { }
    }
}
