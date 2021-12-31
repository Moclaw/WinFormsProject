namespace System
{
    internal class KeyPressEventArgs
    {
        private Action<object, Windows.Forms.KeyPressEventArgs> txtUsername_TextChanged;

        public KeyPressEventArgs(Action<object, Windows.Forms.KeyPressEventArgs> txtUsername_TextChanged)
        {
            this.txtUsername_TextChanged = txtUsername_TextChanged;
        }
    }
}