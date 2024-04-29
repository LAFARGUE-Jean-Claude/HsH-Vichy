using HsH_Vichy.Classes.Commandes;
using HsH_Vichy.Classes.Connection;
using HsH_Vichy.Classes.Crud;
using HsH_Vichy.Classes.Naviguation;
using System.Security.Cryptography.X509Certificates;

namespace Console_HsH_Vichy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectionMySQL connectionMySQL = new ConnectionMySQL();
            Naviguation naviguation = new Naviguation();
            Select select = new Select();
            Insert insert = new Insert();
            Update update = new Update();
            Delete delete = new Delete();

            void Selectiontable()
            {
                naviguation.AllTable();
                for (int i = 0; i<naviguation.tables.Count; i++)
                {
                    Console.WriteLine(i + " : " + naviguation.tables[i]);

                }
                string reponse = Console.ReadLine();
                while (true) {
                    try
                    {
                        int rep = int.Parse(reponse);
                        naviguation.RecupererColonne(naviguation.tables[rep]);
                        Console.Clear();
                        break;
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
            void SelectionAction()
            {
                Console.WriteLine("0 : Select\n1 : Insert\n2 : Update \n3 : Delete\n4 : Retour");
                string reponse = Console.ReadLine();
            }
            Selectiontable();
            SelectionAction();
            Console.ReadKey();


        }
    }
}
