using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Abstract_Member
{
    // Abstract üye => Sadece Abstract classlarda tanımlanabilen üyelerdir(field Hariç). polimorphsim yaklaşımını uygulamak için üyenin abstruct olarak işaretlenmesidir.
    // abstruct üye gövdesi base tarafından değil subclass tarafından tanımlanan üyelerdir.
    // abstruct üyeler subclaslarda override edilmek zorundadır.eğer override edilmezse hata verecektir.
    public abstract class Insan
    {
        public abstract void Dusunce();
    }

    public class Patron : Insan
    {
        public override void Dusunce()
        {
            Console.WriteLine("Personel Çalışmıyor ");
        }
    }
     public class Personel : Insan 
    {
        public override void Dusunce()
        {
            Console.WriteLine("Patron para vermiyor ");
        }
    }
}
