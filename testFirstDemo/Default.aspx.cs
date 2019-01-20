using System;
using System.Web;
using System.Web.UI;
using System.Reflection;

namespace testFirstDemo
{
    
    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            MethodInfo[] mi = sender.GetType().GetMethods();
            foreach(MethodInfo objects in mi){
                System.Console.WriteLine(objects.Name);
                ddl_button1_attr.Items.Add(objects.Name);
            }
            button1.Text = "You clicked me";
        }
    }
}
