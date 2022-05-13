using AccesModifyDemoLibrary;

namespace AccessModifiersDemo
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            ModifiedDataAccess data = new ModifiedDataAccess();
            data.GetUnsecureConnectionInfo();
            //This line can't access private access modifier
            // formerLastName = "test"; 
        }
    }
}