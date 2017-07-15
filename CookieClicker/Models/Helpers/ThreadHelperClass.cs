using System.Windows.Forms;

namespace CookieClicker.Models.Helpers
{
    public static class ThreadHelperClass
    {
        delegate void SetTextCallback(Form f, Control ctrl, string text);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetText(Form form, Control ctrl, string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = SetText;
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }

        delegate void SetEnabledCallback(Form f, Control ctrl, bool bl);
        public static void Enabled(Form form, Control ctrl, bool bl)
        {
            if (ctrl.InvokeRequired)
            {
                SetEnabledCallback e = Enabled;
                form.Invoke(e, new object[] {form, ctrl, bl});
            }
            else
            {
                ctrl.Enabled = bl;
            }
        }
    }
}