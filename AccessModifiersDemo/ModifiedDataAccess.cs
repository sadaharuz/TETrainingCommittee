using AccesModifyDemoLibrary;

namespace AccessModifiersDemo
{
    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }
}