using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Page.Widget.Body.Custom
{
    public partial class KeyBoardCCB : IKeyBoard
    {
        public unsafe void SetAmount(string? amount)
        {
            const string methodId = "setAmount.(Ljava/lang/String;)V";
            IntPtr nativeAmount = JNIEnv.NewString(amount);
            try
            {
                JniArgumentValue[] args = { new JniArgumentValue(nativeAmount) };
                fixed (JniArgumentValue* ptr = args)
                {
                    _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, ptr);
                }
            }
            finally
            {
                JNIEnv.DeleteLocalRef(nativeAmount);
            }
        }

        public unsafe void SetDispAmount(bool dispAmount)
        {
            const string methodId = "setDispAmount.(Z)V";
            JniArgumentValue[] args = { new JniArgumentValue(dispAmount) };
            fixed (JniArgumentValue* ptr = args)
            {
                _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, ptr);
            }
        }

        public unsafe void SetDispMsg(string? msg)
        {
            const string methodId = "setDispMsg.(Ljava/lang/String;)V";
            IntPtr nativeMsg = JNIEnv.NewString(msg);
            try
            {
                JniArgumentValue[] args = { new JniArgumentValue(nativeMsg) };
                fixed (JniArgumentValue* ptr = args)
                {
                    _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, ptr);
                }
            }
            finally
            {
                JNIEnv.DeleteLocalRef(nativeMsg);
            }
        }

        public unsafe void SetDispPwdBox(bool dispPwdBox)
        {
            const string methodId = "setDispPwdBox.(Z)V";
            JniArgumentValue[] args = { new JniArgumentValue(dispPwdBox) };
            fixed (JniArgumentValue* ptr = args)
            {
                _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, ptr);
            }
        }

        public unsafe void SetKeyLen(int keyLen)
        {
            const string methodId = "setKeyLen.(I)V";
            JniArgumentValue[] args = { new JniArgumentValue(keyLen) };
            fixed (JniArgumentValue* ptr = args)
            {
                _members.InstanceMethods.InvokeVirtualVoidMethod(methodId, this, ptr);
            }
        }
    }
}
