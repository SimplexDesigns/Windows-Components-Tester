using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Windows_Components_Tester
{
    public class MyVerticalProgessBar : ProgressBar
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();

        [DebuggerNonUserCode]
        static MyVerticalProgessBar()
        {
        }

        [DebuggerNonUserCode]
        public MyVerticalProgessBar() => MyVerticalProgessBar.__ENCAddToList((object)this);

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            lock (MyVerticalProgessBar.__ENCList)
            {
                if (MyVerticalProgessBar.__ENCList.Count == MyVerticalProgessBar.__ENCList.Capacity)
                {
                    int index1 = 0;
                    int num = checked(MyVerticalProgessBar.__ENCList.Count - 1);
                    int index2 = 0;
                    while (index2 <= num)
                    {
                        if (MyVerticalProgessBar.__ENCList[index2].IsAlive)
                        {
                            if (index2 != index1)
                                MyVerticalProgessBar.__ENCList[index1] = MyVerticalProgessBar.__ENCList[index2];
                            checked { ++index1; }
                        }
                        checked { ++index2; }
                    }
                    MyVerticalProgessBar.__ENCList.RemoveRange(index1, checked(MyVerticalProgessBar.__ENCList.Count - index1));
                    MyVerticalProgessBar.__ENCList.Capacity = MyVerticalProgessBar.__ENCList.Count;
                }
                MyVerticalProgessBar.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.Style |= 4;
                return createParams;
            }
        }
    }
}
