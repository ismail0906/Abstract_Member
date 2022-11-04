namespace _6_Abstract_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel pers = new Personel();
            Patron pat = new Patron();


            DusunceGoster(pers);
            DusunceGoster(pat);

            Console.ReadKey();

            // ABSTRUCT ÜYE VS VİRTUAL ÜYE
            
            // Abstruct üyeler gövdesi base'de tanımlanmaz.
            // Virtual üyeler gövdesi base'de tanımlanmalıdır.
            
            // Abstruct üyeler subclass tarafından ezilerek implement(tamamlanmak) edilmek zorundadır.
            // Virtual üyeler subclass tarafından ezilmek zorunda değildir.

        }
        
        static void DusunceGoster(Insan ins) 
        {
            ins.Dusunce();
        }
    }
}