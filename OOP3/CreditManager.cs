using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // Bu methodlar bu interface a bağlı olan her class içinde olmak zorunda ama her class kendine gore yorumlayabilir.
    // Okunabilirlik icin interface in adi I ile baslar
    // Kendisini implement(extend) eden classların referans numaralarını tutabilir.(Ebeveyni oldugu classların)
    interface ICreditManager
    {
        void Calculate();
        void AnyThing();

    }
}
