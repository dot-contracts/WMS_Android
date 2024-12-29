using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Page.Widget.Body.Custom
{
    public partial class KeyBoard : IKeyBoard
    {
        void IKeyBoard.Enter()
        {
            const string methodId = "enter.()V";
            _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, null);
        }

        void IKeyBoard.SetAmount(string? amount)
        {
            const string methodId = "setAmount.(Ljava/lang/String;)V";
            IntPtr nativeAmount = JNIEnv.NewString(amount);
            try
            {
                JniArgumentValue[] args = { new JniArgumentValue(nativeAmount) };
                _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(nativeAmount);
            }
        }

        void IKeyBoard.SetDispAmount(bool dispAmount)
        {
            const string methodId = "setDispAmount.(Z)V";
            JniArgumentValue[] args = { new JniArgumentValue(dispAmount) };
            _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, args);
        }

        void IKeyBoard.SetDispMsg(string? msg)
        {
            const string methodId = "setDispMsg.(Ljava/lang/String;)V";
            IntPtr nativeMsg = JNIEnv.NewString(msg);
            try
            {
                JniArgumentValue[] args = { new JniArgumentValue(nativeMsg) };
                _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(nativeMsg);
            }
        }

        void IKeyBoard.SetDispPwdBox(bool dispPwdBox)
        {
            const string methodId = "setDispPwdBox.(Z)V";
            JniArgumentValue[] args = { new JniArgumentValue(dispPwdBox) };
            _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, args);
        }

        void IKeyBoard.SetKeyLen(int keyLen)
        {
            const string methodId = "setKeyLen.(I)V";
            JniArgumentValue[] args = { new JniArgumentValue(keyLen) };
            _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, args);
        }
    }
}
