namespace Entidades
{
    public class Login
    {
        protected string email;
        protected string pass;

        public string Email
        {
            get 
            {
                return this.email;
            }
        }

        public string Pass
        {
            get
            {
                return this.pass;
            }
        }

        public Login(string correo, string clave)
        {
            this.email = correo;
            this.pass = clave;
        }

        public bool Loguear() 
        {
            return true;
        }
    }
}
